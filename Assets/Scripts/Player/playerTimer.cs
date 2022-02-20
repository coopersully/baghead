using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class playerTimer : MonoBehaviour
{

    private int _timeLeft = 300;
    public TextMeshProUGUI timerHUD;

    // Initialize Timer HUD and Queue Timer
    void Start()
    {
        RefreshTMP();
        StartCoroutine(Timer());
    }

    // Looping Coroutine for Timer Decrement
    IEnumerator Timer()
    {
        while (_timeLeft <= 300)
        {
            _timeLeft--;
            RefreshTMP();
            if (_timeLeft == 0) Die();
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void RefreshTMP()
    {
        timerHUD.SetText("TIME LEFT: " + (_timeLeft / 60) + ":" + GetSecondsLeft());
        RefreshTMPColor();
    }

    private string GetSecondsLeft()
    {
        int secLeft = _timeLeft % 60;
        if (secLeft >= 10) return secLeft.ToString();
        return "0" + secLeft.ToString();
    }

    private void RefreshTMPColor()
    {
        timerHUD.color = new Color(0.5f, 0f, 0f, 1f);
        if (_timeLeft > 25) timerHUD.color = Color.red;
        if (_timeLeft > 50) timerHUD.color = new Color(1f, 0.67f, 0.15f, 1f);
        if (_timeLeft > 150) timerHUD.color = Color.yellow;
        if (_timeLeft > 200) timerHUD.color = Color.green;
    }
    
    private void Die()
    {
        // Kill player and respawn them
        GameObject respawnPoint = GameObject.FindGameObjectWithTag("Respawn");
        gameObject.transform.SetPositionAndRotation(respawnPoint.transform.position, Quaternion.identity);
        
        // Reset timer
        _timeLeft = 300;
        RefreshTMP();
    }
}
