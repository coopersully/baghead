using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Macrae_platform : MonoBehaviour
{
   
     public GameObject platformPathStart;
    public GameObject platformPathEnd;
    public int speed;
    private Vector3 startPosition;
    private Vector3 endPosition;
    private Rigidbody rBody;
 
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        startPosition = platformPathStart.transform.position;
        endPosition = platformPathEnd.transform.position;
        StartCoroutine(Vector3LerpCoroutine(gameObject, endPosition, speed));
    }
 
    void Update()
    {
        if(rBody.position == endPosition)
        {
            StartCoroutine(Vector3LerpCoroutine(gameObject, startPosition, speed));
        }
        if(rBody.position == startPosition)
        {
            StartCoroutine(Vector3LerpCoroutine(gameObject, endPosition, speed));
        }
    }
 
    IEnumerator Vector3LerpCoroutine(GameObject obj, Vector3 target, float speed)
    {
        Vector3 startPosition = obj.transform.position;
        float time = 0f;
 
        while(rBody.position != target)
        {
            rBody.MovePosition(Vector3.Lerp(startPosition, target, (time/Vector3.Distance(startPosition, target))*speed));
            time += Time.deltaTime;
            yield return null;
        }   
    }
}
