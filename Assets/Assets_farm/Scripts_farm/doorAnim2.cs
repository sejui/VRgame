﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script triggers an ending animation sequence, to open the door
public class doorAnim2 : MonoBehaviour {
	public Animator anim;
	float countdown = 500f;

	void Start(){
		anim = GetComponent<Animator>();

	}
	void OnTriggerEnter(Collider col){

		if (col.gameObject.tag == "Player") {
			anim.Play ("doorOpen2");
		}
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "Player") {
			
			Application.LoadLevel(0);
		}

	}

	void Update(){
		if (countdown <= 0) {
			//fade the camera, load the starting screen 

		}

	}
}
