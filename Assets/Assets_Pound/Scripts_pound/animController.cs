using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

	public Animator anim;
//
	void Start () {
		anim = GetComponent<Animator>();
	}
	
//	 Update is called once per frame
	void OnTriggerEnter(Collider col){
		Debug.Log ("collide");
		if (col.gameObject.tag == "Player") {
			anim.Play ("doorOpen");

		}	
	}
//
//	void update(){
//		if(Input.GetKeyDown(KeyCode.A)){
//			
//		anim.Play ("screwFall1");
//		print("triigered");
//    }
//		if(Input.GetKeyDown("r")){
//
//			anim.Play ("screwFall2");
//			print("triigered");
//		}
//  }
}
