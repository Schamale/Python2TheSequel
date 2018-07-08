﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

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
		//GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, moveVelocity);


		transform.up = GetComponent<Rigidbody2D> ().velocity;


	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "EnemyBoat")
		{
			Debug.Log ("Battle Start!");
		}
	
		SceneManager.LoadScene ("Fight", LoadSceneMode.Single);

	}


}
