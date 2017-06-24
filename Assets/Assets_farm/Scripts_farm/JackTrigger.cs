using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackTrigger : MonoBehaviour {
	public GameObject jack;
	Animator anim;
	int state = 0;
	// Use this for initialization
	void Start () {
		jack = GetComponent<GameObject> ();
		anim = GameObject.Find("jack1").GetComponent<Animator> ();

		if (anim == null) {
			Debug.Log (anim);

		}
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			state += 1;
			Debug.Log (state);
		}

	}

	void Update(){
		if (state == 0) {
			anim.SetBool ("shakeHand",false);
			anim.SetBool ("welcome",false);
		}
		if (state >0 && state<3) {
			anim.SetBool ("shakeHand",true);
			anim.SetBool ("welcome",false);

		}

		if (state >= 3) {
			anim.SetBool ("shakeHand",false);
			anim.SetBool ("welcome",true);

		}

	}
}
