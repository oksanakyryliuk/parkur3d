using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToScene : MonoBehaviour
{
    [SerializeField] private string _nextScene;

    public void Switch()
    {
        SceneManager.LoadScene(_nextScene);
    }
}