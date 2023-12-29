using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBlinkEffects : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public Color blinkColor = Color.red;
    public float blinkInterval = 1.0f;

    private bool isBlinking = false;

    private void Start()
    {
        StartBlinking();
    }

    private void Update()
    {
        if (isBlinking)
        {
            float lerpValue = Mathf.PingPong(Time.time / blinkInterval, 1f);
            textMeshPro.color = Color.Lerp(Color.white, blinkColor, lerpValue);
        }
    }

    private void StartBlinking()
    {
        isBlinking = true;
    }

    private void StopBlinking()
    {
        isBlinking = false;
        textMeshPro.color = Color.white;
    }
}
