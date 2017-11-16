using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedFanController : MonoBehaviour {
	private Animator anim;
	private Transform fanTransform = null;

	public float fanHide = 0;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		fanTransform = transform.Find("AnimatedFan");
	}

	public void BladeRotation() {
		anim.Play ("BladeRotation", 0);
	}

	public void FanHide() {
		fanTransform.Translate (0, fanHide, 0);
		fanTransform.GetComponent<Animator>().enabled = false;
	}

	public void FanReappear() {
		fanTransform.Translate (0, -fanHide, 0);
		fanTransform.GetComponent<Animator>().enabled = true;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
