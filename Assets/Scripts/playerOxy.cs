using System.Collections;
using UnityEngine;
using TMPro;


public class playerOxy : MonoBehaviour
{

    private int _oxygenTotal = 60;
    public TextMeshProUGUI oxygenAmount;
    public AudioSource collectSound;

    // Initialize Oxygen Meter and Queue Timer
    void Start()
    {
        RefreshTMP();
        StartCoroutine(OxygenMeter());
    }

    // Looping Coroutine for Oxygen Decrement
    IEnumerator OxygenMeter()
    {
        while (_oxygenTotal <= 60)
        {
            _oxygenTotal--;
            RefreshTMP();
            if (_oxygenTotal == 0) Suffocate();
            yield return new WaitForSeconds(0.1f);
        }
    }

    // Oxygen Capsule Pickup Handler
    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        if (other.gameObject.CompareTag("OxygenCapsule"))
        {
            other.gameObject.SetActive(false);
            OxygenCollect();
        }
    }
    
    // Restore Oxygen Completely & Refresh Meter
    private void OxygenCollect()
    {
        _oxygenTotal = 60;
        RefreshTMP();
    }

    private void RefreshTMP()
    {
        oxygenAmount.SetText("Oxygen: " + _oxygenTotal + "/60");
        RefreshTMPColor();
    }

    private void RefreshTMPColor()
    {
        oxygenAmount.color = new Color(0.5f, 0f, 0f, 1f);
        if (_oxygenTotal > 20) oxygenAmount.color = Color.red;
        if (_oxygenTotal > 30) oxygenAmount.color = new Color(1f, 0.67f, 0.15f, 1f);
        if (_oxygenTotal > 40) oxygenAmount.color = Color.yellow;
        if (_oxygenTotal > 50) oxygenAmount.color = Color.green;
    }
    
    private void Suffocate()
    {
        // Kill player and respawn them
        GameObject respawnPoint = GameObject.FindGameObjectWithTag("Respawn");
        gameObject.transform.SetPositionAndRotation(respawnPoint.transform.position, Quaternion.identity);
        
        // Reset oxygen meter
        OxygenCollect();
    }
    
}