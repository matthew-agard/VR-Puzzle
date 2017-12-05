using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereOfProgressController : MonoBehaviour {
	private VRTK.VRTK_InteractableObject interactScript;


	// Use this for initialization
	void Start () {
		interactScript = GetComponent<VRTK.VRTK_InteractableObject> ();
		interactScript.isGrabbable = false; 
	}

	void UnlockSphereOfProgress() {
		GetComponent<Renderer> ().material.color = Color.yellow;
		interactScript.isGrabbable = true;
	}

	void OnEnable() {
		SimpleBlockPuzzleController.onPuzzleSolved += UnlockSphereOfProgress;
	}

	void OnDisable() {
		SimpleBlockPuzzleController.onPuzzleSolved -= UnlockSphereOfProgress;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
