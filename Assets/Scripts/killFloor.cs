using UnityEngine;

public class killFloor : MonoBehaviour
{
    
    private GameObject _respawnPoint;

    private void Start()
    {
        _respawnPoint = GameObject.FindGameObjectWithTag("Respawn");
    }
    private void OnTriggerEnter(Collider other) {
        gameObject.transform.SetPositionAndRotation(_respawnPoint.transform.position, Quaternion.identity);
    }

}
