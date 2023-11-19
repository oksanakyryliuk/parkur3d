using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    
    public void Start()
    {
        if(!PlayerPrefs.HasKey("Level"))
        {
            _button.interactable = false;
        }
        else
        {
            _button.onClick.AddListener(LoadLevel);
        }
    }

    private void LoadLevel()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("Level"));
    }
}