using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinge : MonoBehaviour {
	public float forceAmount = 1000f;	
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z == -90) {
			rb.AddForce (transform.forward * forceAmount, ForceMode.Acceleration);
		} else {
			rb.AddForce (-transform.forward * forceAmount, ForceMode.Acceleration);

		}
		rb.useGravity = true;
	}
}
