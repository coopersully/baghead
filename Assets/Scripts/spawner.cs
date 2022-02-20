using System.Collections;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public bool isRandom = true;
    public string waypointTag = "WaywardSpawnpoint";
    public float spawnInterval = 5.0f;
    private GameObject[] _spawnpoints;
    public GameObject mob;
    
    // Start is called before the first frame update
    void Start()
    {
        _spawnpoints = GameObject.FindGameObjectsWithTag(waypointTag);
        StartCoroutine(SpawnCoroutine());
    }

    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            if (isRandom)
            {
                // Spawn a NPC at a random spawnpoint
                Instantiate(mob, _spawnpoints[Random.Range(0, _spawnpoints.Length)].gameObject.transform.position, Quaternion.identity);
            }
            else
            {
                // Spawn a NPC at every spawnpoint
                foreach (var spawnpoint in _spawnpoints)
                {
                    Instantiate(mob, spawnpoint.gameObject.transform.position, Quaternion.identity);
                }
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}