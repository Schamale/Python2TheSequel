using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyIssues : MonoBehaviour 
{
	public GameObject player;

	public void SetParent(GameObject NewParent)
	{
		player.transform.parent = NewParent.transform;
	}

	public void Detach()
	{
		transform.parent = null;
	}

}
