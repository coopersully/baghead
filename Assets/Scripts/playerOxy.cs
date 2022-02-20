using System.Collections;
using UnityEngine;
using TMPro;


public class playerOxy : MonoBehaviour
{

    private int _oxygenTotal = 60;
    public TextMeshProUGUI oxygenAmount;

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
            yield return new WaitForSeconds(1);
        }
    }

    // Oxygen Capsule Pickup Handler
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OxygenCapsule"))
        {
            collision.gameObject.SetActive(false);
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
    }
}