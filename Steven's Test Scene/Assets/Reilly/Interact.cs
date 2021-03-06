﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{

	public Cannon cannon;
	public Button b;
	public GameObject spaw;
	public GameObject player;
	public FightPlayer fightPlayer;
    AudioSource audioSource;

	private bool go = false;

	void Start()
	{
		cannon = FindObjectOfType<Cannon> ();
		fightPlayer = FindObjectOfType<FightPlayer> ();
        audioSource = GetComponent<AudioSource>();
	}

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

			if (cannon.loaded)
			{
				return;
			}
			if (player.transform.rotation.x != 0 || player.transform.rotation.y != 0 || player.transform.rotation.z != 0) 
			{
				player.transform.rotation = Quaternion.Euler (0f, 0f, 0f);
			}
			if (player.transform.rotation.x == 0 && player.transform.rotation.y == 0 && player.transform.rotation.z == 0) {
				GameObject spawn = Instantiate (spaw);

				spawn.transform.SetParent (player.transform, false);

				spawn.transform.position = new Vector3 (player.transform.position.x - 1.8f, player.transform.position.y - .5f, player.transform.position.z);

				spawn.transform.rotation = Quaternion.Euler (0f, 0f, 0f);

				b.interactable = false;

				go = false;

				Debug.Log ("Interacted");
				fightPlayer.cannonsInBarrel -= 1;
                audioSource.Play();
            }
			}
	}
}
