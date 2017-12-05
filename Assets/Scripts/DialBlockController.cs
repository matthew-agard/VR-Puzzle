using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialBlockController : MonoBehaviour {

	public float unitsPerDegree = 0.001f;
	public Vector3 axis = Vector3.up;

	private GameObject mDial;
	private GameObject mBlock;
	private Vector3 mPrevDialRotation;

	// Use this for initialization
	void Start () {
		// get references to our dial and block game objects
		mBlock = transform.Find("Block").gameObject;
		GameObject handController = transform.Find ("HandController").gameObject;
		GameObject controllerBase = handController.transform.Find ("Base").gameObject;
		mDial = controllerBase.transform.Find ("Dial").gameObject;
		// get initial angle rotation of dial
		mPrevDialRotation = mDial.transform.localEulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		// get current rotation angle of dial
		Vector3 curDialRotation = mDial.transform.localEulerAngles;
		// If the dial has rotated since the last frame update the position
		// of the block. Dial is rotating around the y axis
		if (curDialRotation != mPrevDialRotation) {
			float dialRotation = curDialRotation.y - mPrevDialRotation.y;

			// Check if dial was rotated past 12 o'clock
			if (mPrevDialRotation.y > 270 && curDialRotation.y < 90) {
				// Dial rotated clockwise past 12 o'clock
				dialRotation += 360;
			} else if (mPrevDialRotation.y < 90 && curDialRotation.y > 270) {
				dialRotation -= 360;
			}

			float blockMoveDist = unitsPerDegree * dialRotation;
			// move the block
			mBlock.transform.Translate (axis * blockMoveDist);
			mPrevDialRotation = curDialRotation;
		}
	}

}
