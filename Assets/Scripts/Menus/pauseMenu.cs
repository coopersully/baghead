using System;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject menu;
    private GameObject _oxygenHUD;

    private void Start()
    {
        _oxygenHUD = GameObject.FindGameObjectWithTag("OxygenHUD");
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if (_oxygenHUD != null) _oxygenHUD.SetActive(false);
        menu.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Resume()
    {
        if (_oxygenHUD != null) _oxygenHUD.SetActive(true);
        menu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
