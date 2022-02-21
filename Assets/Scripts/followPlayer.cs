using UnityEngine;

public class followPlayer : MonoBehaviour
{
 
 private Transform target;
 [Range(0, 1)] public double smoothSpeed = 0.125;
 [SerializeField] private Vector3 offset;

 void Start()
 {
  target = GameObject.FindWithTag("Player").transform;
 }
 void LateUpdate()
 {
  transform.position = target.position + offset;
 }

}
