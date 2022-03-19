using UnityEngine;

public class playerFall : MonoBehaviour
{
    
    private GameObject _respawnPoint;
    [SerializeField] private int yAxisBoundary;

    private void Start()
    {
        _respawnPoint = GameObject.FindGameObjectWithTag("Respawn");
    }

    private void Update()
    {
        // If the player crosses below a certain point on the y-axis
        if (gameObject.transform.position.y < yAxisBoundary)
        {
            gameObject.transform.SetPositionAndRotation(_respawnPoint.transform.position, Quaternion.identity);
        }
    }

}
