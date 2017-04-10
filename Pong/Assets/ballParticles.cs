using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballParticles : MonoBehaviour {

	public ParticleSystem ps;

	// Use this for initialization
	void Start () {
		
	}

	void onParticleCollision(Collision other) {
		ps.Emit (1);
		Renderer rOther = other.GetComponent<Renderer> ();
		rOther.material.color = new Color (0f,0f,0f);
	}

	// Update is called once per frame
	void Update () {

	}
}
