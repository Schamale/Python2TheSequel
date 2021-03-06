﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour {

	public Transform player;
	public int currentPoint;
	public Transform[] wayPoints;
	public bool following = false;
    public GameObject[] boatPrefabs;
    public BoatManager[] b;



	private Transform target;
	private float moveSpeed = .05f;
	private float maxRange = 15f;

	//private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		var heading = player.position - transform.position;
        
		if (transform.position == wayPoints [currentPoint].position)
		{
			currentPoint++;
		}


	
		//transform.position = Vector3.MoveTowards (transform.position, wayPoint1.position, moveSpeed);
		if (heading.sqrMagnitude < maxRange * maxRange)
		{
			following = true;
			transform.position = Vector3.MoveTowards (transform.position, player.position, moveSpeed);
		} else
			following = false;


		if (following == false)
		{
			transform.position = Vector3.MoveTowards (transform.position, wayPoints [currentPoint].position, moveSpeed);

			if (transform.position == wayPoints [currentPoint].position)
			{
				currentPoint++;
			}

			if (currentPoint >= 3)
			{
				currentPoint = 0;
			}


		}
			
		if (following)
			target = player;
		else
			target = wayPoints [currentPoint];
		transform.LookAt (target);
		transform.rotation = new Quaternion (0f, 0f, transform.rotation.z, transform.rotation.w);
		transform.Rotate (0f, 0f, 90f);
		if(currentPoint == 0)
			transform.Rotate (0f, 0f, 180f);
		


		
	}



}
