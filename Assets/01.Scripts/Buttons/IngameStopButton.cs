using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IngameStopButton : MonoBehaviour
{
    public GameObject CenterImg;

    private void Awake()
    {
        CenterImg.SetActive(false);
    }

    public void StopButton()
    {
        CenterImg.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeButton()
    {
        CenterImg.SetActive(false);
        Time.timeScale = 1f;
    }

    public void SaveButton()
    {
        Debug.Log("Saved");
        // Save 기능 구현
    }

    public void LoadButton()
    {
        Debug.Log("Load");
        // Load 기능 구현 + Load용 팝업창 만들기
    }

    public void ReturnTitleButton()
    {
        SceneManager.LoadScene("02.TitleScene");
    }
}
