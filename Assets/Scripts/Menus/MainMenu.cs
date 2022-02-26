using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public AudioSource clickSound;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ClickSound()
    {
        clickSound.Play();
    }
}
