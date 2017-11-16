using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour {
	public float openAngle = 0;    // Angle when lid is open
	public float closeAngle = 0;   // Angle when lid is closed

	private Transform chestLidTransform = null;

	// Use this for initialization
	void Start () {
		// Get transform for the Lid mesh
		chestLidTransform = transform.Find("Lid");
		// Get current angle of lid
		float startingAngle = chestLidTransform.localEulerAngles.z;
		// Make sure lid is closed to begin with
		chestLidTransform.Rotate(0, 0, closeAngle - startingAngle);
	}

	// Open the chest lid
	public void OpenLid() {
		chestLidTransform.Rotate (0, 0, openAngle);
		Debug.Log ("Open Lid");
	}

	// Close the chest lid
	public void CloseLid() {
		chestLidTransform.Rotate (0, 0, -openAngle);
		Debug.Log ("Close Lid");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
