using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSaver : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetString("Level", SceneManager.GetActiveScene().name);
    }
}