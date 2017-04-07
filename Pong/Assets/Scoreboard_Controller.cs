using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;
using UnityEngine;

public class Scoreboard_Controller : MonoBehaviour {

	public static Scoreboard_Controller instance;

	public Text PlayerOneScoreText;
	public Text PlayerTwoScoreText;

	public int playerOneScore;
	public int playerTwoScore;

	// Use this for initialization
	void Start () {

		instance = this;
		 
		playerOneScore = playerTwoScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GivePlayerOneAPoint () {
		playerOneScore += 1;

		PlayerOneScoreText.text = playerOneScore.ToString ();
	}

	public void GivePlayerTwoAPoint	() {
		playerTwoScore += 1;

		PlayerTwoScoreText.text = playerTwoScore.ToString ();
	}
}
