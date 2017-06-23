using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dalwalk : MonoBehaviour {
	Rigidbody rigi;
	Animator anim;
	// Use this for initialization
	void Start () {
		rigi = gameObject.GetComponent<Rigidbody> ();
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (rigi.IsSleeping()) {

			anim.SetBool ("run", false);
		} else {
			anim.SetBool ("run", true);
		}
	}
}
