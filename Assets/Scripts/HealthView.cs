using UnityEngine;

public class HealthView : MonoBehaviour
{
    public ProgressBar ProgressBar;
    public Health Health;

    private void Start()
    {
        Health.Changed += UpdateProgressBar;
        UpdateProgressBar();
    }
    
    private void OnDestroy()
    {
        Health.Changed -= UpdateProgressBar;
    }

    private void UpdateProgressBar()
    {
        ProgressBar.SetValue(Health.CurrentHealth/Health.MaxHealth);
    }
}