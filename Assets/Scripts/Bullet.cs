using System;
using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _damage;
    
    private Rigidbody _rigidbody;

    public float Damage => _damage;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        StartCoroutine(DestroyAfterTime());
    }

    public void StartFlying(Vector3 direction)
    {
        _rigidbody.velocity = direction * _speed;
    }

    private IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}