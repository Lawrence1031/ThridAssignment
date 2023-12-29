using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleSceneButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private RectTransform rectTransform;
    private Vector2 originalSize;
    private Vector2 originalPosition;

    public Vector2 hoverSize = new Vector2(250, 400);
    public Vector2 hoverPositionOffset = new Vector2(0, -60f);

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        originalSize = rectTransform.sizeDelta;
        originalPosition = rectTransform.position;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        rectTransform.sizeDelta = hoverSize;
        rectTransform.position = originalPosition + hoverPositionOffset;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rectTransform.sizeDelta = originalSize;
        rectTransform.position = originalPosition;
    }

    public void MainButton()
    {
        Debug.Log("Main");
        SceneManager.LoadScene("03.MainScene");
    }

    public void LoadButton()
    {
        Debug.Log("Load");
        // Load 기능 구현 예정
    }

    public void CollectionButton()
    {
        Debug.Log("Collection");
        SceneManager.LoadScene("99.CollectionScene");
    }

    public void ExitButton()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void StartButton()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("02.TitleScene");
    }
}
