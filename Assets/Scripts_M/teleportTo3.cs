using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportTo3 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("teleport begins");
        //		other.transform.position = new Vector3(29,1,22);
        Application.LoadLevel(3);   //you can also put in the scene number instead of the name: Application.LoadLevel(1);
    }
}
