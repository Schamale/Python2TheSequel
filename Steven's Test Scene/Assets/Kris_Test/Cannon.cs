using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

	public float cannonMove;
	public float moveSpeed;
	public Rigidbody2D cannonBall;
	public Transform cannonSpawn;

	public float launchForce = 15;
	public bool fired;

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
			Rigidbody2D cannonBallInstance = Instantiate (cannonBall, cannonSpawn.position, cannonSpawn.rotation) as Rigidbody2D;
			cannonBallInstance.velocity = launchForce * cannonSpawn.up;


		}



			GetComponent<Rigidbody2D> ().rotation -= cannonMove;
	}



}
