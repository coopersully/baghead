using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelLoader : MonoBehaviour
{
    
    public GameObject loadingScreen;
    public Slider progressBar;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(AsyncLoader(sceneIndex));
    }

    private IEnumerator AsyncLoader(int sceneIndex)
    {
        
        loadingScreen.SetActive(true);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneIndex);
        
        while (!asyncOperation.isDone)
        {
            progressBar.value = asyncOperation.progress;
            yield return null;
        }
    }
}
