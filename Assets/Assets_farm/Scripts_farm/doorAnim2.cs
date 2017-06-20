using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorAnim2 : MonoBehaviour {
	public Animator anim;
//	public AudioSource windchime;
	void Start(){
		anim = GetComponent<Animator>();
//		windchime = GetComponent<AudioSource> ();
	}
	void OnTriggerEnter(Collider col){
		Debug.Log ("trigger mill animation");
//		windchime.Play ();
		if (col.gameObject.tag == "Player") {
			anim.Play ("doorOpen2");

		}
	}
}
