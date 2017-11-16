using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour {
	private bool isTargeted;  // Is player focused on this target?
	public float playerHeight = 1.8f;

	// Teleport the player
	public void Teleport() {
		if (isTargeted) {
			// Player is looking at this target
			// when they clicked their headset
			GameObject player = GameObject.FindWithTag ("Player");
			if (player != null) {
				// Move the player to the location of the target
				Vector3 newPosition = new Vector3 (transform.position.x, transform.position.y + playerHeight,
					                      transform.position.z);

				player.transform.position = newPosition;
			}
		}
	}

	public void SetGazedAt(bool gazedAt) {
		// Highlight target when it's looked at
		if (gazedAt == true)
			GetComponent<Renderer> ().material.EnableKeyword ("_EMISSION");
		else
			GetComponent<Renderer> ().material.DisableKeyword ("_EMISSION");

		// Gazing at the target means it's targeted by player
		isTargeted = gazedAt;
	}

	// Use this for initialization
	void Start () {
		SetGazedAt(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
