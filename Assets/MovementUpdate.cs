using UnityEngine;

public class MovementUpdate : MonoBehaviour
{
   public float speed = .1f;
   public float jumpSpeed = .2f;
  

   private void Update()
   {
      float xDirection = Input.GetAxis("Horizontal");
      float yDirection = Input.GetAxis("Vertical");
      Vector3 moveDirection = new Vector3(xDirection,yDirection, 0);
      transform.position += moveDirection * speed;
   }
}
