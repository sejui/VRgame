using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorque : MonoBehaviour {

    public float amount = 50f;
    Collision other;

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;

        other.rigidbody.AddTorque(transform.up * h);
        other.rigidbody.AddTorque(transform.right * v);
    }
}
