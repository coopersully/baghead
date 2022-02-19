using System.Collections;
using UnityEngine;

public class WaywardSpawner : MonoBehaviour
{
    //public float spawnInterval = 10.0f;
    private GameObject[] _spawnpoint;
    public GameObject wayward;

    public int xPos;// Bridget added
    public int yPos;// Bridget added
    
    // Start is called before the first frame update
    void Start()
    {
        _spawnpoint = GameObject.FindGameObjectsWithTag("WaywardSpawnpoint");
        StartCoroutine(SpawnCoroutine());
    }

    IEnumerator SpawnCoroutine()
    { 
        while (true)
        {
            //Instantiate(wayward, _spawnpoint[Random.Range(0, _spawnpoint.Length)].gameObject.transform.position, Quaternion.identity);
            xPos = Random.Range(0, 50);
            yield return new WaitForSeconds(10);
        }
    }
}