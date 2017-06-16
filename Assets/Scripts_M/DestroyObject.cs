using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	void DestroyObjectOnCol (Collision col){
		{ if (col.gameObject.name == "Sofa"){
				Destroy(col.gameObject);
			}
		}
					
}
}
