using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour {
	public float forceApplied = 0;
	void OnTriggerEnter(Collider other){
		Debug.Log (gameObject + "trigger" + other.gameObject);
		other.transform.Rotate (2*Time.deltaTime,0,0);
		//other.gameObject.GetComponent<Rigidbody>().AddForce (0, forceApplied, 0);
	}

	void OnCollisionEnter(Collision col){
		Debug.Log (gameObject.name + "has coolided with" + col.gameObject.name);
		col.rigidbody.AddForce (-transform.forward*forceApplied,ForceMode.Acceleration);
		col.transform.Rotate (2*Time.deltaTime,0,0);

	}
	void OnCollisionExit(Collision col){

		col.transform.Rotate (2*Time.deltaTime,0,0);
	}

}
