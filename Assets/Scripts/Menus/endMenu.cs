using UnityEngine;
using UnityEngine.SceneManagement;

public class endMenu : MonoBehaviour
{
    public GameObject menu;
    
    public void Activate()
    {
        menu.SetActive(true);
        Time.timeScale = 0.25f;
    }
    public void StartOver() => SceneManager.LoadScene(1);
    public void QuitGame() => Application.Quit();

}
