using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    private bool hasTapped = false;
    public GameObject tapIndicator; 

    void Start()
    {
        // Initialize communication
        PlayerPrefs.DeleteKey("UnityMessage");
        PlayerPrefs.Save();

        if (tapIndicator != null)
            tapIndicator.SetActive(false);
    }

    public void OnScreenTapped()
    {
        if (hasTapped) return;
        hasTapped = true;

        // Send completion message to Flutter
        PlayerPrefs.SetString("UnityMessage", "IntroFinished");
        PlayerPrefs.Save();
        Debug.Log("Unity intro completed - message sent to Flutter");

        // Load next scene
        SceneManager.LoadScene("DSI");
    }

    // Call this when text typing is complete to show tap indicator
    public void ShowTapIndicator()
    {
        if (tapIndicator != null)
            tapIndicator.SetActive(true);
    }
}