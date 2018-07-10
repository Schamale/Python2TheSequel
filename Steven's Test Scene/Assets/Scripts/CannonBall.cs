using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour {

	public Cannon cannon;
	private float maxLifeTime = .7f;


	// Use this for initialization
	void Start () {
		cannon = FindObjectOfType<Cannon> ();
		if (cannon.cannonActive)
			Destroy (gameObject, maxLifeTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
