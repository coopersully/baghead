using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howToPlayMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public AudioSource clickSound;

    public void FadeMainMenu()
    {
        mainMenu.SetActive(false);
        gameObject.SetActive(true);
    }
    
    public void FadeThisMenu()
    {
        gameObject.SetActive(false);
        mainMenu.SetActive(true);
    }
    
    private void ClickSound()
    {
        clickSound.Play();
    }
}
