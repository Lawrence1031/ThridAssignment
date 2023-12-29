using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public Image fadeOutImg;
    private Color tmpColor;
    
    private void Start()
    {
        tmpColor = Color.black;
        tmpColor.a = 1f;
        fadeOutImg.color = tmpColor;
    }

    public void FadeOut()
    {
        tmpColor.a -= 0.01f;
        fadeOutImg.color = tmpColor;
    }

    IEnumerable Fade()
    {
        yield return new WaitForSecondsRealtime(0.02f);
    }
}
