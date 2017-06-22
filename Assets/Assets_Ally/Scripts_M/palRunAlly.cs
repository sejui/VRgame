using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palRunAlly : MonoBehaviour {
	//this class is used for controlling the dogpal animator. 
	Rigidbody rigi;
	Animator anim;


	// Use this for initialization
	void Start () {
		rigi = gameObject.GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (rigi.IsSleeping ()) {
			anim.SetBool ("run", false);
		} 
		if (!rigi.IsSleeping ()){
			anim.SetBool ("run", true);
		}
	}
}
