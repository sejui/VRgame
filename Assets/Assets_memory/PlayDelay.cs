using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayDelay : MonoBehaviour {
    public AudioSource source;
    //public AudioClip clip;
    //private bool isPlayed;
    public float timer; 

    public void Awake()
    {
        source = GetComponent<AudioSource>();
        source.PlayDelayed(timer);

    }
}
