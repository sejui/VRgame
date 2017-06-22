using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this script triggers an ending animation sequence, to open the door
public class doorAnim : MonoBehaviour {
	public Animator anim;

	void Start(){
		anim = GetComponent<Animator>();

	}
	void OnTriggerEnter(Collider col){

		if (col.gameObject.tag == "Player") {
			anim.Play ("doorOpen");

		}
	}
}
