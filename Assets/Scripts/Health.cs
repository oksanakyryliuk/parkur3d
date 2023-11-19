using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _startHealth = 100;

    public float CurrentHealth { get; private set; }
    public float MaxHealth => _startHealth;
    
    public event Action Changed;

    private void Awake()
    {
        CurrentHealth = _startHealth;
    }

    public void TakeDamage(float amount)
    {
        CurrentHealth -= amount;
        Changed?.Invoke();
    }
}