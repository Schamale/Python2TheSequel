using System.Collections;
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

	private bool go = false;

	void Start()
	{
		cannon = FindObjectOfType<Cannon> ();
		fightPlayer = FindObjectOfType<FightPlayer> ();
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

			GameObject spawn = Instantiate (spaw);

			spawn.transform.SetParent (player.transform, false);

			spawn.transform.position = new Vector3 (player.transform.position.x - .05f, player.transform.position.y + 1f, player.transform.position.z);

			spawn.transform.rotation = Quaternion.Euler (0f, 0f, 0f);

			b.interactable = false;

			go = false;

			Debug.Log ("Interacted");
			fightPlayer.cannonsInBarrel -= 1;
		}
	}
}
