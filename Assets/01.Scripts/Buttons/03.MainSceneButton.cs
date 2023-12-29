using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneButton : MonoBehaviour
{
    public GameObject background;

    public void Chapter01Button()
    {
        SceneManager.LoadScene("04.Chapter_01");
    }

}
