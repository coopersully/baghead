using UnityEngine;

public class cameraFollow : MonoBehaviour
{
 
 public Transform target;
 
 public double smoothSpeed = 0.125;
 public Vector3 offset;

 void LateUpdate()
 {
  transform.position = target.position + offset;
 }

}
