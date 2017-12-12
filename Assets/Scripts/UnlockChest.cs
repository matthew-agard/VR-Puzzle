using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockChest : MonoBehaviour {
	private VRTK.VRTK_InteractableObject interactScript;
	private GameObject mLid;

	// Use this for initialization
	void Start () {
		mLid = transform.Find ("Lid").gameObject;
		interactScript = mLid.GetComponent<VRTK.VRTK_InteractableObject> ();
		interactScript.isGrabbable = false;
	}

	void Unlock() {
		GetComponent<Renderer> ().material.color = Color.yellow;
		interactScript.isGrabbable = true;
	}

	void OnEnable() {
		SimpleBlockPuzzleController.onPuzzleSolved += Unlock;
	}

	void OnDisable() {
		SimpleBlockPuzzleController.onPuzzleSolved -= Unlock;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
