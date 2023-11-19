using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();
        _health.Changed += CheckIfDied;
    }

    private void OnDestroy()
    {
        _health.Changed -= CheckIfDied;
    }

    private void CheckIfDied()
    {
        if(_health.CurrentHealth <= 0)
        {
            RestartLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out DieZone dieZone))
        {
            RestartLevel();
        }
    }

    private static void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}