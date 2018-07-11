using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recieve : MonoBehaviour 
{
	public Button b;

	public GameObject player;

	public Cannon cannon;

	private bool go = false;

	public GameObject dot;

	void Start()
	{
		cannon = FindObjectOfType<Cannon> ();
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
			if (player.transform.childCount == 0) 
			{
				return;
			}

			foreach (Transform child in player.transform) 
			{
				GameObject.Destroy (child.gameObject);
			}

			b.interactable = false;

			Debug.Log ("Interacted");
			cannon.loaded = true;
			cannon.cannonActive = true;

			dot.SetActive(true);

			player.SetActive(false);
		}
	}
}
