using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ballController : MonoBehaviour {
	public ParticleSystem ps;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		//Pause ball logic for 2.5 seconds
		StartCoroutine (Pause ());
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfBallInArena ();
	}

	IEnumerator Pause () {
		transform.position = Vector3.zero;

		// Wait for 2.5 seconds
		yield return new WaitForSeconds (2.5f);
		// Call LaunchBall function
		LaunchBall ();
	}

	void CheckIfBallInArena () {
		if (transform.position.x < -13f) {
			
			// If right bat scores...
			Debug.Log ("Right bat scores");
			rb.velocity = Vector3.zero;
			StartCoroutine( Pause());

			// Give player 2 one point
			scoreboardController.instance.GivePlayerTwoAPoint ();

		} else if (transform.position.x > 13f) {
			
			// If left bat scores...
			Debug.Log ("Left bat scores");
			rb.velocity = Vector3.zero;
			StartCoroutine( Pause());

			// Give player 1 one point
			scoreboardController.instance.GivePlayerOneAPoint();
		}
	}

	void LaunchBall () {
		
		// Resets position to center
		transform.position = Vector3.zero;

		// Ball Chooses a direction
		// Flies that direction

		// Flip a coin, determine direction in x-axis
		int xDirection = Random.Range(0, 2);

		//Flip another coin, determine direction in y-axis
		int yDirection = Random.Range(0, 3);


		Vector3 launchDirection = new Vector3 ();

		//Check results of one coin toss
		if (xDirection == 0) {

			launchDirection.x = -8f;
		}
		if (xDirection == 1) {

			launchDirection.x = 8f;
		}

		//Check results of second coin toss
		if (yDirection == 0) {

			launchDirection.y = 0;
		}
		if (yDirection == 1) {

			launchDirection.y = -8f;
		}
		if (yDirection == 2) {

			launchDirection.y = 8f;
		}

		//Assign velocity based off of where we launch ball
		rb.velocity = launchDirection;
	}
	// When collide with an object...
	void OnCollisionEnter (Collision hit) {
		//If it was the top or bottom of the screen...
		ps.Emit(10);
		StartCoroutine (stopParticles ());
		if (hit.gameObject.name == "TopBounds") {
			float speedInXDirection = 0f;

			if (rb.velocity.x > 0f)
				speedInXDirection = 8f;

			if (rb.velocity.x < 0f)
				speedInXDirection = -8f;

			rb.velocity = new Vector3 (speedInXDirection, -8f, 0f);
		}

		if (hit.gameObject.name == "BottomBounds") {

			float speedInXDirection = 0f;

			if (rb.velocity.x > 0f)
				speedInXDirection = 8f;

			if (rb.velocity.x < 0f)
				speedInXDirection = -8f;

			rb.velocity = new Vector3 (speedInXDirection, 8f, 0f);
		}

		if (hit.gameObject.name == "Left_Bat") {
			rb.velocity = new Vector3 (13f, 0f, 0f);


			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y < -.75) {

				rb.velocity = new Vector3 (8f, -8f, 0f);
			}
			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y > .75f) {

				rb.velocity = new Vector3 (8f, 8f, 0f);
			}
		}

		if (hit.gameObject.name == "Right_Bat") {
			rb.velocity = new Vector3 (-13f, 0f, 0f);


			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y < -.75f) {

				rb.velocity = new Vector3 (-8f, -8f, 0f);
			}
			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y > .75f) {

				rb.velocity = new Vector3 (-8f, 8f, 0f);
			}
		}
	}
	IEnumerator stopParticles() {
		yield return new WaitForSeconds (2f);
		ParticleSystem.EmissionModule em = ps.emission;
		em.enabled = false;
	}
}
