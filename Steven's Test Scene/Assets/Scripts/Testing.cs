using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour {

	public Transform player;
	public Transform wayPoint1;
	private float maxRange = 15f;

	private float moveSpeed = .05f;
	//private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		var heading = player.position - transform.position;

		float step = moveSpeed * Time.deltaTime;
		//transform.position = Vector3.MoveTowards (transform.position, wayPoint1.position, moveSpeed);
		if (heading.sqrMagnitude < maxRange * maxRange)
		{
			transform.position = Vector3.MoveTowards (transform.position, player.position, moveSpeed);
		}
	}
}
