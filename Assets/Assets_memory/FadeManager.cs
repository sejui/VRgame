using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//manage the fadd in/out effect
public class FadeManager : MonoBehaviour {
	
	public static FadeManager Instance {
		set;
		get;
	}

	public Image thisImage;
	private bool isInTransition;
	private float transition;
	private bool isShowing;
	private float duration;

	public GameObject timer;
	private float timeleft;


	private void Awake () {
		Instance = this;
//		timeleft = timer.GetComponent<CountingDown> ().timeLeft;
	}

	public void Fade(bool showing, float duration){
		isShowing = showing;
		isInTransition = true;
		this.duration = duration;
		transition = (isShowing) ? 0 : 1;

	}

	private void Update(){
		timeleft = timer.GetComponent<CountingDown> ().timeLeft;
		Debug.Log (timeleft);


		if (timeleft < 11 && timeleft >10)
			Fade (false, 3.0f);
		if (timeleft < 5 && timeleft > 4)
			Fade (true, 4.0f);


		if (!isInTransition)
			return;

		transition += (isShowing) ? Time.deltaTime * (1 / duration) : -Time.deltaTime * (1 / duration);
		thisImage.color = Color.Lerp (new Color (0, 0, 0, 0), new Color (0, 0, 0, 1), transition);

		if (transition > 1 || transition < 0)
			isInTransition = false;

	}
}
