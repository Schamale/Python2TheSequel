using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour {

	private float maxLifeTime = .7f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, maxLifeTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
