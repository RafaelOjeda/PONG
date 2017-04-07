using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {

	// Script that handles input from two players
	// Player 1 => controls left bat with W/S keys
	// Player 2 => controls right bat with UP/DOWN keys

	public GameObject leftBat;
	public GameObject rightBat;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// ----------
		//	LEFT BAT
		// ----------

		// Default speed of the left bat is 0
		leftBat.GetComponent<Rigidbody>().velocity = new Vector3 (0f, 0f, 0f);

		// If the player is pressing the W key...
		if (Input.GetKey (KeyCode.W)) {

			// Move the bat up
			Debug.Log("Player 1 is pressing W");
			// Set velocity to up 1
			leftBat.GetComponent<Rigidbody>().velocity = new Vector3 (0f, 5f, 0f);
		}

		// If the player is pressing the S key...
		else if (Input.GetKey (KeyCode.S)) {

			//Move the bat down
			Debug.Log("Player 1 is pressing S");
			// Set velocity to -1
			leftBat.GetComponent<Rigidbody>().velocity = new Vector3 (0f, -5f, 0f);
		}
		// If you aren't pressing any keys the speed is 0

		// ----------
		//	RIGHT BAT
		// ----------

		// Default speed of the right bat is 0
		rightBat.GetComponent<Rigidbody>().velocity = new Vector3 (0f, 0f, 0f);

		// If the player is pressing the DownArrow key...
		if (Input.GetKey (KeyCode.UpArrow)) {

			// Move the bat up
			Debug.Log("Player 2 is pressing UpArrow");
			// Set velocity to up 1
			rightBat.GetComponent<Rigidbody>().velocity = new Vector3 (0f, 5f, 0f);
		}

		// If the player is pressing the DownArrow key...
		else if (Input.GetKey (KeyCode.DownArrow)) {

			//Move the bat down
			Debug.Log("Player 2 is pressing DownArrow");
			// Set velocity to -1
			rightBat.GetComponent<Rigidbody>().velocity = new Vector3 (0f, -5f, 0f);
		}
		// If you aren't pressing any keys the speed is 0
	}
}
