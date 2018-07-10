using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightPlayer : MonoBehaviour {

	public Cannon cannon;
	public GameObject player;
	public float horizontalVelocity;
	public float verticalVelocity;
	private float moveSpeed = 10f;



	// Use this for initialization
	void Start () {
		cannon = FindObjectOfType<Cannon> ();
	}
		
	
	// Update is called once per frame
	void Update () {
		if (cannon.cannonActive == false)
		{
			verticalVelocity = 0f;
			horizontalVelocity = 0f;
			//Used to go right
			if (Input.GetKey (KeyCode.D))
			{
				//GetComponent<Rigidbody2D> ().rotation = -90f;
				//GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
				horizontalVelocity = moveSpeed;

			}


			//Used to go left
			if (Input.GetKey (KeyCode.A)) 
			{
				//GetComponent<Rigidbody2D> ().rotation = 90f;
				//GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
				horizontalVelocity = -moveSpeed;

			}


			//Used to go up
			if (Input.GetKey (KeyCode.W)) 
			{
				//GetComponent<Rigidbody2D> ().rotation = 0f;
				verticalVelocity = moveSpeed;

			}

			//Used to go down
			if (Input.GetKey (KeyCode.S)) 
			{
				//GetComponent<Rigidbody2D> ().rotation = 180f;
				verticalVelocity = -moveSpeed;

			}
				

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (horizontalVelocity, verticalVelocity);
		}
	}
}
