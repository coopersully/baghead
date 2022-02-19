using UnityEngine;

public class platformMovement : MonoBehaviour
{
    // Player gets onto platform
    private void OnCollisionEnter(Collision collision)
    {
        // Bring player with the platform (sync movement)
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.parent = transform;
        }
    }

    // Player exits the platform
    private void OnCollisionExit(Collision collision)
    {
        // Reset movement sync
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.parent = null;
        }
    }
}