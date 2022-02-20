using System.Collections;
using UnityEngine;

public class randomPlayerSpawn : MonoBehaviour
{
    public float placeX;
    public float placeY;
    public GameObject wayward;

    void Start()
    {
        placeX = Random.Range(210, 28);
        placeY = Random.Range(29, 3);
        wayward.transform.position = new Vector3(placeX, placeY, 0);

    }
}
