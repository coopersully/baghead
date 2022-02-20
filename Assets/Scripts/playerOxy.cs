using System.Collections;
using UnityEngine;
using TMPro;


public class PlayerOxy : MonoBehaviour
{

    private int _oxygenTotal = 60;
    public TextMeshProUGUI oxygenAmount;

    void Start()
    {
        RefreshTMP();
        StartCoroutine(OxygenMeter());
    }

    IEnumerator OxygenMeter()
    {
        while (_oxygenTotal <= 60)
        {
            _oxygenTotal--;
            RefreshTMP();
            yield return new WaitForSeconds(1);
        }

        //add a way for when the capsules are collected add to oxygen
        print("No more air.");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("oxygen"))
        {
            collision.gameObject.SetActive(false);
            OxygenCollect();
        }
    }

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