using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

	public float cannonMove;
	public float moveSpeed;
	public GameObject cannonBall;
	public Transform cannonSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		cannonMove = 0f;
		//Used to turn left
		if (Input.GetKey (KeyCode.A)) 
		{
			if (GetComponent<Rigidbody2D> ().rotation < 45f)
			{
				cannonMove = -moveSpeed;
			}
		}

		//Used to turn right
		if (Input.GetKey (KeyCode.D))
		{
			if (GetComponent<Rigidbody2D> ().rotation > -45f)
			{
				cannonMove = moveSpeed;
			}
		}

		if (Input.GetKeyDown ("space"))
		{
			Instantiate (cannonBall, cannonSpawn.position, cannonSpawn.rotation);
		}



			GetComponent<Rigidbody2D> ().rotation -= cannonMove;
	}
}
