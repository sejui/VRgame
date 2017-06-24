using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escapeBtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("joystick button 2"))
			Application.LoadLevel (1);
	}
}
