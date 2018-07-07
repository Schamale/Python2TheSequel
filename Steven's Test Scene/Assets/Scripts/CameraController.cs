using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public TestPlayer player;
	public bool isFollowing = true;

	public float xOffset;
	public float yOffset;

	void Start(){
		player = FindObjectOfType<TestPlayer> ();

		isFollowing = true;

	}


	void LateUpdate(){
		
		if (isFollowing)
		{
			transform.position = new Vector3 (player.transform.position.x + xOffset, player.transform.position.y + yOffset, transform.position.z); 
		}
	}
}