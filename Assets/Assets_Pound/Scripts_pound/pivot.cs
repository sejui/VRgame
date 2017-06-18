using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivot : MonoBehaviour {

	public float pivotSize = .75f;
	public Color pivotColor = Color.yellow;

	void onDrawGizmos(){
		Gizmos.color = pivotColor;
		Gizmos.DrawWireSphere (transform.position, pivotSize);
	}

}
