using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour {

	public float moveSpeed;
	public float horizontalVelocity;
	public float verticalVelocity;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		horizontalVelocity = 0f;
		verticalVelocity = 0f;


		//Used to go right
		if (Input.GetKey (KeyCode.D))
		{
			//GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			horizontalVelocity = moveSpeed;

		}


		//Used to go left
		if (Input.GetKey (KeyCode.A)) 
		{
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			horizontalVelocity = -moveSpeed;

		}


		//Used to go up
		if (Input.GetKey (KeyCode.W)) 
		{
			verticalVelocity = moveSpeed;

		}

		//Used to go down
		if (Input.GetKey (KeyCode.S)) 
		{
			verticalVelocity = -moveSpeed;

		}


		GetComponent<Rigidbody2D> ().velocity = new Vector2 (horizontalVelocity, verticalVelocity);
		//GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, moveVelocity);

		//This flips the sprite depending on which direction you are going.
		if (GetComponent<Rigidbody2D> ().velocity.x > 0)
			transform.localScale = new Vector3 (1f, 1f, 1f);
		else if (GetComponent<Rigidbody2D> ().velocity.x < 0)
			transform.localScale = new Vector3 (-1f, 1f, 1f);



	}
}
