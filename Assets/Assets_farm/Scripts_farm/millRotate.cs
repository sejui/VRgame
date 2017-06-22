using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class millRotate : MonoBehaviour {
	public Animator anim;
	public AudioSource windchime;
	void Start(){
		anim = GetComponent<Animator>();
		windchime = GetComponent<AudioSource> ();
	}
	void OnTriggerEnter(Collider col){
		
		windchime.Play ();
		if (col.gameObject.tag == "Player") {
			anim.Play ("millRotate");

		}
	}
}
