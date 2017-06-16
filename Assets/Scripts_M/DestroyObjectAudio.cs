using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectAudio : MonoBehaviour
{

    public AudioClip boom;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = boom;
    }

    void OnTriggerEnter()
    {
        GetComponent<AudioSource>().Play();
    }
}
