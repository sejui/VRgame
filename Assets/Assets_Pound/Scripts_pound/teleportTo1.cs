using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportTo1 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("teleport begins");
        //		other.transform.position = new Vector3(29,1,22);
		if(other.tag == "Player")
        Application.LoadLevel(1);   //you can also put in the scene number instead of the name: Application.LoadLevel(1);
    }
}
