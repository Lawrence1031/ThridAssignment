using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextTypingEffect : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float typingSpeed = 0.05f;
    public float blinkSpeed = 1f;
    public GameObject nextButton;

    private string originalText;
    private string currentText;

    private void Start()
    {
        nextButton.SetActive(false);

        originalText = textMeshPro.text;

        textMeshPro.text = "";
        currentText = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        for (int i = 0; i <= originalText.Length; i++)
        {
            currentText = originalText.Substring(0, i);
            textMeshPro.text = currentText;

            yield return new WaitForSeconds(typingSpeed);
        }

        nextButton.SetActive(true);

        while (true)
        {
            currentText = originalText.Substring(0, originalText.Length);
            textMeshPro.text = currentText;
            yield return new WaitForSeconds(blinkSpeed);

            currentText = originalText.Substring(0, originalText.Length - 1);
            textMeshPro.text = currentText;
            yield return new WaitForSeconds(blinkSpeed);
        }
    }
}
