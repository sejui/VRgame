using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour {

    public AudioClip boom;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = boom;
    }

    private void OnCollisionEnter(Collision obj)
    {
        GetComponent<AudioSource>().Play();
        if (obj.gameObject.name == "cbBox")
        {
            Destroy(obj.gameObject);
        }
    }
}
