using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalRun : MonoBehaviour {
	//this class is used for controlling the dogpal animator. 
	Rigidbody rigi;
	Animator anim;

	//get boolean from the pallTrigger2 class
	bool playerTriggered;

	public GameObject obj;


	// Use this for initialization
	void Start () {
		rigi = gameObject.GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
		//GameObject.Find ("palTrigger_no.2")
		playerTriggered = obj.GetComponent<DogSitTrigger> ().triggeredByDog;


		anim.SetBool ("2ndTrigger", false);
		anim.SetBool ("run", false);

	}
	
	// Update is called once per frame
	void Update () {
		//constantly update to check the boolean
		playerTriggered = obj.GetComponent<DogSitTrigger> ().triggeredByDog;
		if (playerTriggered) {
			anim.SetBool ("2ndTrigger", true);

		} 
		if (!playerTriggered){
			anim.SetBool ("2ndTrigger", false);
		}

		if (rigi.IsSleeping ()) {
			
			anim.SetBool ("run", false);


		} 
		if (!rigi.IsSleeping ()){

			anim.SetBool ("run", true);
		}
			
	}


}
