using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedChestController : MonoBehaviour {
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	public void OpenLid() {
		// Play the OpenLid state in animator controller
		anim.CrossFade ("OpenLid", 1);
	}

	public void CloseLid() {
		// Play the CloseLid state in animator controller
		anim.CrossFade ("CloseLid", 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
