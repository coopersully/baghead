using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pickups : MonoBehaviour
{
    private int canistersCollected;
    public TextMeshProUGUI oxygenCount;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag.Equals("oxygen")) {
            canistersCollected++;
            oxygenCount.SetText("Oxygen Count: " + canistersCollected);
            other.gameObject.SetActive(false);
        }
    }

}
