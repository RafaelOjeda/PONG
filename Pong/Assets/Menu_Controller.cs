using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_Controller : MonoBehaviour {

	// Use this for initialization 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame () {
		SceneManager.LoadScene (1);
		Debug.Log ("Loaded Game");
	}

	public void QuitGame () {
		Application.Quit ();
	}
}
