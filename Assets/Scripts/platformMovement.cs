using System;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("OxygenCapsule"))
        {
            collision.transform.parent = transform;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("OxygenCapsule") )
        {
            other.transform.parent = null;
        }
    }
}