using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is to change the states of animators
public class animateChange : MonoBehaviour {
	//get animator of the gameobject
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//get the vector
		float move = Input.GetAxis ("Vertical");
		//if the axis is changed, set speed to the vector
		anim.SetFloat ("speed", 1);

	}
}
