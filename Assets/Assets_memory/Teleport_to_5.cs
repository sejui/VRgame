using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is to load the farm scene
public class Teleport_to_5 : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			Application.LoadLevel(5);

		}

	}
}
