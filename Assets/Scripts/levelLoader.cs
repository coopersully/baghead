using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelLoader : MonoBehaviour
{
    
    public GameObject loadingScreen;
    public TextMeshProUGUI subtitle;
    public Slider progressBar;
    public string[] tips = new string[]
    {
        "If you run out of oxygen, you'll suffocate!",
        "Be careful not to die, then you'll be dead!",
        "Losing all your health causes you to die, watch out!",
        "Originally, the Bagheads used plastic bags... They aren't with us anymore.",
        "Watch out for the wayward! When they kill you, you die!",
        "One time it rained in the cardboard city... It didn't go well.",
        "Try not to get wet or you'll drown, causing you to die.",
        "Loading screens usually have helpful tips. This one doesn't!"
    };

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(AsyncLoader(sceneIndex));
    }

    private IEnumerator AsyncLoader(int sceneIndex)
    {
        
        loadingScreen.SetActive(true);
        subtitle.SetText(tips[Random.Range(0,  tips.Length)]);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneIndex);
        
        while (!asyncOperation.isDone)
        {
            progressBar.value = asyncOperation.progress;
            yield return null;
        }
    }
}
