﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportTo2 : MonoBehaviour {
    // load the ally scene
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("teleport begins");
        //		other.transform.position = new Vector3(29,1,22);
        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel(2);   //you can also put in the scene number instead of the name: Application.LoadLevel(1);
        }
    }

}
	