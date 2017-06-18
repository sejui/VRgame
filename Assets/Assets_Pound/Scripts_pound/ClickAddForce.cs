using VRStandardAssets.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAddForce : MonoBehaviour {
	[SerializeField] private VRInteractiveItem m_InteractiveItem;
	public float forceApplied = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnEnable()
	{
		m_InteractiveItem.OnClick += HandleClick;
	}
	private void OnDisable()
	{
		m_InteractiveItem.OnClick -= HandleClick;
	}

	private void HandleClick()
	{
		Debug.Log("Show click state");
//		gameObject.rigidbody.AddForce (-transform.forward*forceApplied,ForceMode.Acceleration);
		//Destroy(gameObject);
	}
}
