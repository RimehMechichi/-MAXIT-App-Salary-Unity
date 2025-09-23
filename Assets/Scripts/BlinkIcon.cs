using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BlinkIcon : MonoBehaviour
{
    public Image icon;
    public float interval = 0.5f;
    private bool isBlinking = true;

    void Start()
    {
        if (icon == null)
        {
            Debug.LogError("Icon not assigned to BlinkIcon script!");
            return;
        }
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        while (isBlinking)
        {
            if (icon != null)
            {
                icon.enabled = !icon.enabled;
            }
            yield return new WaitForSeconds(interval);
        }
    }

    void OnDestroy()
    {
        isBlinking = false;
    }
}