using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource clickSound;

    public void QuitGame()
    {
        Application.Quit();
    }

    private void ClickSound()
    {
        clickSound.Play();
    }
}
