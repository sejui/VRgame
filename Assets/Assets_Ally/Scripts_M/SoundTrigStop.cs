using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigStop : MonoBehaviour {
    public AudioSource source;
    public AudioSource source2;
    //public AudioClip clip;
    private bool isPlayed;

    public void Awake()
    {
        source = GetComponent<AudioSource>();
        source2 = GetComponent<AudioSource>();
        isPlayed = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!isPlayed)
        {
            source.Play();
            isPlayed = true;
            source2.Stop();
        }
    }


    private void OnTriggerExit(Collider other)
    {
     if (source.isPlaying)
        {
            source.Stop();
        }   
    }

}