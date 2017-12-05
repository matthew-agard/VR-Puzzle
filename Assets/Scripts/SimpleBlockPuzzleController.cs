using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBlockPuzzleController : MonoBehaviour {
	public delegate void OnSolved ();

	public static event OnSolved onPuzzleSolved;

	public float tolerance;

	private GameObject mRedBlock;
	private GameObject mBlueBlock;
	private float mBlueHeight;

	// Use this for initialization
	void Start () {
		mRedBlock = transform.Find ("RedBlock").gameObject;
		mBlueBlock = transform.Find ("BlueBlock").gameObject;
		mBlueHeight = mBlueBlock.GetComponent<Renderer> ().bounds.size.y;
	}
		
	// Return true if puzzle is solved.
	bool IsSolved() {
		Vector3 RedPosition = mRedBlock.transform.position;
		Vector3 BluePosition = mBlueBlock.transform.position;

		if (RedPosition.y > BluePosition.y
		    && (RedPosition.y - BluePosition.y) < mBlueHeight + tolerance
		    && Mathf.Abs (RedPosition.x - BluePosition.x) < tolerance
		    && Mathf.Abs (RedPosition.z - BluePosition.z) < tolerance) {
			// Red block on top of blue block

			if (onPuzzleSolved != null) {
				// Notify other game objects that the puzzle is solved
				onPuzzleSolved ();
			}
			return true;
		}
		return false;
	}

	// Update is called once per frame
	void Update () {
		if (IsSolved () == true) {
			// Puzzle has been solved. turn blocks yellow
			mRedBlock.GetComponent<Renderer> ().material.color = Color.yellow;
			mBlueBlock.GetComponent<Renderer> ().material.color = Color.yellow;
		}
	}
}
