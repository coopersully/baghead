using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject menu;
    
    public void Start()
    {
        Resume();
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
        menu.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Resume()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
