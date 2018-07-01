using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Player player;
	public bool isFollowing = true;

	public float xOffset;
	public float yOffset;

	void Start(){
		player = FindObjectOfType<Player> ();

		isFollowing = true;

	}


	void Update(){

		if (isFollowing)
		{
			transform.position = new Vector3 (player.transform.position.x + xOffset, player.transform.position.y + yOffset, transform.position.z); 
		}
	}
}