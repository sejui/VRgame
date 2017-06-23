using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingDown : MonoBehaviour {
	//create a timer;
	public float timeLeft = 20.0f;

	void Update()
	{
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			Application.LoadLevel (4); //back to the ally 
		}
	}
}
