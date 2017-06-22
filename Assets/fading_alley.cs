using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fading_alley : MonoBehaviour {

	IEnumerator FadeToNextLevel() {
		float fadetime = GameObject.Find("FPSController").GetComponent<fading>().BeginFade(1);
		yield return new WaitForSeconds(fadetime);
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
