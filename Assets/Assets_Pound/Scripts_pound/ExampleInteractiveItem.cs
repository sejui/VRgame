using UnityEngine;
using VRStandardAssets.Utils;
using System.Collections;

namespace VRStandardAssets.Examples
{
    // This script is a simple example of how an interactive item can
    // be used to change things on gameobjects by handling events.
    public class ExampleInteractiveItem : MonoBehaviour
    {
		public Rigidbody rb;

		//initialize the glow effect shader
//		private Behaviour halo;

//        [SerializeField] private Material m_NormalMaterial;                
//        [SerializeField] private Material m_OverMaterial;                  
//        [SerializeField] private Material m_ClickedMaterial;               
//        [SerializeField] private Material m_DoubleClickedMaterial;         
        [SerializeField] private VRInteractiveItem m_InteractiveItem;
        [SerializeField] private Renderer m_Renderer;
		[SerializeField] private SelectionRadial m_SelectionRadial;         // This controls when the selection is complete.

		private bool m_GazeOver;                                            // Whether the user is looking at the VRInteractiveItem currently.

		public void start(){
			rb = GetComponent<Rigidbody> ();
//			halo = GetComponent<"Halo">;
//			halo = (Behaviour)GetComponent("Halo");
//			halo.enabled = false;
			(gameObject.GetComponent("Halo") as Behaviour).enabled = false;
		}


        private void Awake ()
        {
//            m_Renderer.material = m_NormalMaterial;
        }


        private void OnEnable()
        {
            m_InteractiveItem.OnOver += HandleOver;
            m_InteractiveItem.OnOut += HandleOut;
//            m_InteractiveItem.OnClick += HandleClick;
//            m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
			m_SelectionRadial.OnSelectionComplete += HandleSelectionComplete;
        }


        private void OnDisable()
        {
            m_InteractiveItem.OnOver -= HandleOver;
            m_InteractiveItem.OnOut -= HandleOut;
//            m_InteractiveItem.OnClick -= HandleClick;
//            m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
        }


        //Handle the Over event
        private void HandleOver()
        {
            Debug.Log("Show over state");

			//enable the glow shader when mouse hover on a game object
//            m_Renderer.material = m_OverMaterial;

			(gameObject.GetComponent("Halo") as Behaviour).enabled = true;


			// When the user looks at the rendering of the scene, show the radial.
			m_SelectionRadial.Show();

			m_GazeOver = true;
        }


        //Handle the Out event
        private void HandleOut()
        {
            Debug.Log("Show out state");
			//disable the glow effect when mouse unhover
//            m_Renderer.material = m_NormalMaterial;

			(gameObject.GetComponent("Halo") as Behaviour).enabled = false;
			// When the user looks away from the rendering of the scene, hide the radial.
			m_SelectionRadial.Hide();

			m_GazeOver = false;
        }


        //Handle the Click event
//        void HandleClick()
//        {
//            Debug.Log("Show click state");
//            m_Renderer.material = m_ClickedMaterial;
//			if (gameObject.name == "plant") {
//				Debug.Log ("plant is clicked");
//				rb.AddForce (-transform.forward*50,ForceMode.Acceleration);
//			}
//			//Destroy(gameObject);
//        }
//

        //Handle the DoubleClick event
//        private void HandleDoubleClick()
//        {
//            Debug.Log("Show double click");
//            m_Renderer.material = m_DoubleClickedMaterial;
//        }

		private void HandleSelectionComplete()
		{
			Debug.Log("Show selection");
			// If the user is looking at the rendering of the scene when the radial's selection finishes, activate the button.
			if(m_GazeOver)
				//Hides the game object, then hides selection reticle
				gameObject.SetActive(false);
				HandleOut();
		}
    }

}