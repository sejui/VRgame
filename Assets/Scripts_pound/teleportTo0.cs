using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Need to add this if using SceneManager.LoadScene()

public class teleportTo0 : MonoBehaviour {

	/*
	 * Teleport to another scene!
	 * 
	 * Step 1: Click and drag this script onto a Cube GameObject (or whatever GameObject you want the player to run into to teleport)
	 * 
	 * Step 2: Select the Cube and in the inspector under Box Collider check the box next to IS TRIGGER
	 * 
	 * Step 3: Go to File > Build Settings and add your scenes into the build editor (e.g., "Desert.unity")
	 * 
	 * Step 4 (optional): you can make the Cube invisible by disabling the Mesh Renderer in the inspector
	 * 
	 * Voila!
	*/

	void OnTriggerEnter(Collider other)
	{
		Application.LoadLevel(0);	//you can also put in the scene number instead of the name: Application.LoadLevel(1);
	}
		


	//Application.LoadLevel() is become obsolete, so instead you can use this script below

	/*
	void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene("maureen.unity");
	}
*/

}
