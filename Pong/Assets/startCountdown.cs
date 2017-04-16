using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startCountdown : MonoBehaviour {
	public Text startTimeText;
	public int startTimeInt;
	// Use this for initialization
	void Start () {
		StartCoroutine (Timer ());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator Timer () {
		while (startTimeInt >= 0) {
			startTimeText.text = startTimeInt.ToString ();
			Debug.Log (startTimeInt);
			startTimeInt--;
			yield return new WaitForSeconds (1f);
			if (startTimeInt == 0) {
				yield return new WaitForSeconds (1f);

				SceneManager.LoadScene (2);
			}
		}
	}
}
