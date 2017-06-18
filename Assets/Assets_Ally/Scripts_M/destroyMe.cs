using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryMe : MonoBehaviour {
//	public GameObject dogfood;

	void Start(){

//		dogfood = GameObject<> ();
	}
	void OnCollisionEnter(Collision col){
		Debug.Log ("collide");
		if (col.gameObject.name == "Bowl") {
			Destroy (col.gameObject);

		}	
	}
}
 