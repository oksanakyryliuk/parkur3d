using UnityEngine;

public class DamageTaker : MonoBehaviour
{
    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.TryGetComponent<Bullet>(out var bullet))
        {
            Destroy(bullet.gameObject);
            _health.TakeDamage(bullet.Damage);
        }
    }
}