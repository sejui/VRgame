using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palTrigger2 : MonoBehaviour {
	//this script is used to control the animator of the dogpal, 
	//when triggers, the dog pal will move and perform animation. 
	Animator palContainer;
	public bool triggedByPlayer = false;

	// Use this for initialization
	void Start () {

		palContainer = GameObject.Find("dogPal").GetComponent<Animator> ();


		if (palContainer == null) {
			Debug.Log (palContainer);

		}
	}

	// Update is called once per frame
	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			palContainer.SetBool ("palTrigger2", true);
			Debug.Log ("triggered");
			triggedByPlayer = true;
		}

	}
}
