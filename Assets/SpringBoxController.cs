using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBoxController : MonoBehaviour {

	void OnJointBreak(float breakForce) {
		Debug.Log ("Spring joint has broken. Force + " + breakForce);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
