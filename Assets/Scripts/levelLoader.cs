using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class levelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public TextMeshProUGUI subtitle;
    public Slider progressBar;
    public string[] tips = {
        "IF YOU RUN OUT OF OXYGEN, YOU'LL SUFFOCATE!",
        "BE CAREFUL NOT TO DIE, THEN YOU'LL BE DEAD!",
        "LOSING ALL YOUR HEALTH CAUSES YOU TO DIE, WATCH OUT!",
        "ORIGINALLY, THE BAGHEADS USED PLASTIC BAGS... THEY AREN'T WITH US ANYMORE.",
        "WATCH OUT FOR THE WAYWARD! WHEN THEY KILL YOU, YOU DIE!",
        "ONE TIME IT RAINED IN THE CARDBOARD CITY... IT DIDN'T GO WELL.",
        "TRY NOT TO GET WET OR YOU'LL DROWN, CAUSING YOU TO DIE.",
        "LOADING SCREENS USUALLY HAVE HELPFUL TIPS. THIS ONE DOESN'T!"
    };

    public void OnTriggerEnter(Collider other)
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

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
