using System.Collections;
using UnityEngine;
using TMPro;


public class playerOxy : MonoBehaviour
{

    private int _oxygenTotal = 30;
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
        while (_oxygenTotal <= 30)
        {
            _oxygenTotal--;
            RefreshTMP();
            if (_oxygenTotal == 0) Suffocate();
            yield return new WaitForSeconds(1f);
        }
    }

    // Oxygen Capsule Pickup Handler
    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        if (other.gameObject.CompareTag("OxygenCapsule"))
        {
            Debug.Log("trigger entered");
            other.gameObject.SetActive(false);
            OxygenCollect();
        }
    }
    
    // Restore Oxygen Completely & Refresh Meter
    // Macrae Edited this to only fill oxygen halfway
    private void OxygenCollect()
    {
        _oxygenTotal += 30;
        if (_oxygenTotal > 30)
        {
            _oxygenTotal = 30;
        }
        RefreshTMP();
    }

    private void RefreshTMP()
    {
        oxygenAmount.SetText("Oxygen: " + _oxygenTotal + "/30");
        RefreshTMPColor();
    }

    private void RefreshTMPColor()
    {
        oxygenAmount.color = new Color(0.5f, 0f, 0f, 1f);
        if (_oxygenTotal > 0) oxygenAmount.color = Color.red;
        if (_oxygenTotal > 5) oxygenAmount.color = new Color(1f, 0.67f, 0.15f, 1f);
        if (_oxygenTotal > 10) oxygenAmount.color = Color.yellow;
        if (_oxygenTotal > 20) oxygenAmount.color = Color.green;
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