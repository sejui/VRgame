using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {

    private float force = 1000f;
    public GameObject playerObject;

    void OnCollisionEnter(Collision other)
    {
        other.rigidbody.AddForce(-transform.forward * force, ForceMode.Acceleration);

    }
}
