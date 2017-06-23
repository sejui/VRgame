using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour {

    public AudioSource source;
    //public AudioClip clip;
    private bool isPlayed;

    public void Awake()
    {
        source = GetComponent<AudioSource>();
        isPlayed = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!isPlayed)
        {
            source.Play();
            isPlayed = true;
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
