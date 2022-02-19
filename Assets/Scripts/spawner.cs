using System.Collections;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnInterval = 5.0f;
    private GameObject[] _spawnpoints;
    public GameObject wayward;
    
    // Start is called before the first frame update
    void Start()
    {
        _spawnpoints = GameObject.FindGameObjectsWithTag("WaywardSpawnpoint");
        StartCoroutine(SpawnCoroutine());
    }

    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            Instantiate(wayward, _spawnpoints[Random.Range(0, _spawnpoints.Length)].gameObject.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}