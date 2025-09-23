using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSkipWelcome : MonoBehaviour
{
    public float delay = 3f; // seconds

    void Start()
    {
        Invoke("GoToARScene", delay);
    }

    void GoToARScene()
    {
        SceneManager.LoadScene("ARScene");
    }
}
