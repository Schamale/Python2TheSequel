﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
	public Button b;
	public GameObject spaw;
	public GameObject player;

	private bool go = false;

	void OnTriggerEnter2D ()
	{
		go = true;
	}

	void OnTriggerExit2D()
	{
		go = false;
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.E) && go == true) 
		{
			if (player.transform.childCount > 0) 
			{
				return;
			}

			GameObject spawn = Instantiate (spaw);

			spawn.transform.SetParent (player.transform, false);

			spawn.transform.position = new Vector3 (player.transform.position.x + 0.65f, player.transform.position.y + 0.65f, player.transform.position.z);

			b.interactable = false;

			go = false;

			Debug.Log ("Interacted");
		}
	}
}