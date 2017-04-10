using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInputController : MonoBehaviour {

	// Script that handles input from two players
	// Player 1 => controls left bat with W/S keys
	// Player 2 => controls right bat with UP/DOWN keys


	public GameObject leftBat;  //so this is what you originally had, which is right. you get the object itself, which is the bat inside the scene
	public GameObject rightBat; // same thing, but for the right bat
	public Rigidbody leftRB; // this here is GOING TO BE the rigidbody that is attached to the left bat
	public Rigidbody rightRB; // this is GOING TO BE the rb attached to the right bat

	public static playerInputController instance;

	// right, because the system needs to know what TYPE it's going to be. 
	// Use this before initialization of game
	void Awake () {
		leftRB = leftBat.GetComponent<Rigidbody> ();
		rightRB = rightBat.GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {
		instance = this;
	}

	// Update is called once per frame
	void Update () {

		// ----------
		//	LEFT BAT
		// ----------

		// Default speed of the left bat is 0
		leftRB.velocity = new Vector3 (0f, 0f, 0f); // then down here, you are using that same leftRB and changing its velocity

		// If the player is pressing the W key...
		if (Input.GetKey (KeyCode.W)) {

			// Move the bat up
			Debug.Log("Player 1 is pressing W");
			// Set velocity to up 1
			leftRB.velocity = new Vector3 (0f, 5f, 0f);
		}

		// If the player is pressing the S key...
		else if (Input.GetKey (KeyCode.S)) {

			//Move the bat down
			Debug.Log("Player 1 is pressing S");
			// Set velocity to -1
			leftRB.velocity = new Vector3 (0f, -5f, 0f);
		}
		// If you aren't pressing any keys the speed is 0

		// ----------
		//	RIGHT BAT
		// ----------

		// Default speed of the right bat is 0
		rightRB.velocity = new Vector3 (0f, 0f, 0f);

		// If the player is pressing the DownArrow key...
		if (Input.GetKey (KeyCode.UpArrow)) {

			// Move the bat up
			Debug.Log("Player 2 is pressing UpArrow");
			// Set velocity to up 1
			rightRB.velocity = new Vector3 (0f, 5f, 0f);
		}

		// If the player is pressing the DownArrow key...
		else if (Input.GetKey (KeyCode.DownArrow)) {

			//Move the bat down
			Debug.Log("Player 2 is pressing DownArrow");
			// Set velocity to -1
			rightRB.velocity = new Vector3 (0f, -5f, 0f);
		}
		// If you aren't pressing any keys the speed is 0
	}
}
