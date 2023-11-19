using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image Image;

    public void SetValue(float percents)
    {
        Image.fillAmount = percents;
    }
}