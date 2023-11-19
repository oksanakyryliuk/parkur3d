using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Vector3 _offset;
        
    [SerializeField]
    private Transform _target;
    private Transform _transform;

    private void Awake() =>
        _transform = transform;

    private void LateUpdate()
    {
        if (_target != null)
        {
            _transform.position = _target.position + _offset;
            transform.LookAt(_target);
        }
    }
}