﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportTo4 : MonoBehaviour {
	//this is to load the after-memo scene

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			Application.LoadLevel(4);

		}

	}
}
