using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightPlayer : MonoBehaviour {

	public Cannon cannon;
	public GameObject player;
	public Rigidbody2D play;
	public float horizontalVelocity;
	public float verticalVelocity;
	public int cannonsInBarrel = 20;
	public GameObject LoadedInfo;


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

				transform.up = GetComponent<Rigidbody2D> ().velocity;

				if (Input.GetKeyDown (KeyCode.D)) 
				{
					transform.Rotate (0f, 0f, -90f);

					GetComponent<Rigidbody2D> ().freezeRotation = true;
				}
			}


			//Used to go left
			if (Input.GetKey (KeyCode.A)) 
			{
				//GetComponent<Rigidbody2D> ().rotation = 90f;
				//GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
				horizontalVelocity = -moveSpeed;

				transform.up = GetComponent<Rigidbody2D> ().velocity;

				if (Input.GetKeyDown (KeyCode.A)) 
				{
					transform.Rotate (0f, 0f, 90f);

					GetComponent<Rigidbody2D> ().freezeRotation = true;
				}
			}


			//Used to go up
			if (Input.GetKey (KeyCode.W)) 
			{
				//GetComponent<Rigidbody2D> ().rotation = 0f;
				verticalVelocity = moveSpeed;

				transform.up = GetComponent<Rigidbody2D> ().velocity;

				if (Input.GetKeyDown (KeyCode.W)) 
				{
					transform.Rotate (0f, 0f, 0f);

					GetComponent<Rigidbody2D> ().freezeRotation = true;
				}
			}

			//Used to go down
			if (Input.GetKey (KeyCode.S)) 
			{
				//GetComponent<Rigidbody2D> ().rotation = 180f;
				verticalVelocity = -moveSpeed;

				transform.up = GetComponent<Rigidbody2D> ().velocity;

				if (Input.GetKeyDown (KeyCode.S)) 
				{
					transform.Rotate (0f, 0f, 180f);

					GetComponent<Rigidbody2D> ().freezeRotation = true;
				}


			}
				

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (horizontalVelocity, verticalVelocity);



			if (Input.GetKey (KeyCode.None)) 
			{
				GetComponent<Rigidbody2D> ().freezeRotation = true;
			}
		}

		if (LoadedInfo.activeInHierarchy == true) 
		{
			play.velocity = Vector3.zero;
		}
	}

	void OnTriggerEnter()
	{
		if (transform.rotation.x != 0f && transform.rotation.y != 0f && transform.rotation.z != 0f) 
		{
			transform.rotation = Quaternion.Euler (0f, 0f, 0f);
		}
	}
}
