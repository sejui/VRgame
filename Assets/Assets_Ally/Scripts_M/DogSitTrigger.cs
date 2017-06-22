using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSitTrigger : MonoBehaviour {
	public bool triggeredByDog;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){

		if (col.tag == "pal") {
			triggeredByDog = true;

		} else {

			triggeredByDog = false;
		}

	}
}
