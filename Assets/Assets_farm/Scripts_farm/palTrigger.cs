using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palTrigger : MonoBehaviour {
	//this script is used to control the animator of the dogpal, 
	//when triggers, the dog pal will move and perform animation. 
	Animator palContainer;
//	Rigidbody rigi;
	public GameObject container;

	// Use this for initialization
	void Start () {
		
		palContainer = container.GetComponent<Animator> ();
//		pal = GameObject.Find("SheepDog").GetComponent<Animator> ();
//		rigi = GameObject.Find("SheepDog").GetComponent<Rigidbody> ();


		if (palContainer == null) {
			Debug.Log (palContainer);

		}
	}

	// Update is called once per frame
	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			palContainer.SetBool ("palTrigger1", true);
			
		}

	}
	// Update is called once per frame
	void Update () {

	}
}
