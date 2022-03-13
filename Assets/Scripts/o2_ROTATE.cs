using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o2_ROTATE : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(2, 15, 0) * Time.deltaTime * 10);
    }
}
