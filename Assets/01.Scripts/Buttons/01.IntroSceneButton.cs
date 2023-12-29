using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSceneButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject blood;
    public TextMeshProUGUI textMeshPro;

    private void Awake()
    {
        blood.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        blood.SetActive(true);
        textMeshPro.text = "��Ȥ�� ��ȭå �̾߱�";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        blood.SetActive(false);
        textMeshPro.text = "�������� �д� ��ȭå";
    }
    public void StartButton()
    {
        Debug.Log("Title");
        SceneManager.LoadScene("02.TitleScene");
    }
}
