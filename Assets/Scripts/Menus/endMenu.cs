using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endMenu : MonoBehaviour
{
    public GameObject menu;

    public void Start()
    {
        //menu.SetActive(false);
    }

    public void Activate()
    {
        menu.SetActive(true);
        Time.timeScale = 0.25f;
    }

    public void StartOver()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
