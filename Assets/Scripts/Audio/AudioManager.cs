using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource BGM;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ChangeBGM(AudioClip music)
    {
          BGM.Stop();
          BGM.clip = music;
          BGM.Play();
    }
}
