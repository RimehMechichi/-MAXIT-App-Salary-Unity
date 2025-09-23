using UnityEngine;
using TMPro;
using System.Collections;

public class TypewriterText : MonoBehaviour
{
    public TMP_Text textBox;
    [TextArea] public string message;
    public float delay = 0.05f;

    public System.Action OnTextComplete; // Event when typing finishes

    void Start()
    {
        if (textBox == null)
        {
            Debug.LogError("TextBox not assigned to TypewriterText script!");
            return;
        }
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        textBox.text = "";
        foreach (char c in message)
        {
            textBox.text += c;
            yield return new WaitForSeconds(delay);
        }

        // Trigger completion event
        OnTextComplete?.Invoke();
    }
}