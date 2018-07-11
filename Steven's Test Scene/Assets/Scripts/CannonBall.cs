using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour {

	public Cannon cannon;
	private float maxLifeTime = .7f;


	// Use this for initialization
	void Start () 
	{
		cannon = FindObjectOfType<Cannon> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y >= 50f)
			DestroyObject(this.gameObject);	

		if (cannon.loadInfo.activeInHierarchy == true) 
		{
			Destroy(GetComponent<CircleCollider2D>());
		}
	}
}
