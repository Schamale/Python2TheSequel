using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cannon : MonoBehaviour {

	public float cannonMove;
	public float moveSpeed;
	public Rigidbody2D cannonBall;
	public Transform cannonSpawn;
	public Slider aimSlider;
	public GameObject loadInfo;

	private bool loaded;
	public float minLaunchForce = 15f;
	public float maxLaunchForce = 30f;
	public float maxChargeTime = 0.75f;


	private float currentLaunchForce;
	private float chargeSpeed;
	private bool fired;

	private void OnEnable()
	{
		currentLaunchForce = minLaunchForce;
		aimSlider.value = minLaunchForce;

	}


	// Use this for initialization
	void Start () {
		chargeSpeed = (maxLaunchForce - minLaunchForce) / maxChargeTime;
	}
	
	// Update is called once per frame
	void Update () {
		cannonMove = 0f;
		//Used to turn left
		if (Input.GetKey (KeyCode.A)) 
		{
			if (GetComponent<Rigidbody2D> ().rotation < 45f)
			{
				cannonMove = -moveSpeed;
			}
		}

		//Used to turn right
		if (Input.GetKey (KeyCode.D))
		{
			if (GetComponent<Rigidbody2D> ().rotation > -45f)
			{
				cannonMove = moveSpeed;
			}
		}

		if (Input.GetKey (KeyCode.LeftControl))
		{
			loaded = true;
			loadInfo.SetActive (true);
		}

		aimSlider.value = minLaunchForce;

		if (currentLaunchForce > maxLaunchForce && !fired)
		{
			currentLaunchForce = maxLaunchForce;
			Fire ();
		}

		else if (Input.GetKeyDown ("space"))
		{
			fired = false;
			currentLaunchForce = minLaunchForce;
		}

		else if (Input.GetKey ("space") && !fired && loaded)
		{
			currentLaunchForce += chargeSpeed * Time.deltaTime;

			aimSlider.value = currentLaunchForce;
		}

		else if (Input.GetKeyUp ("space") && !fired && loaded)
		{
			Fire ();


		}



			GetComponent<Rigidbody2D> ().rotation -= cannonMove;
	}

	private void Fire()
	{
		loaded = false;
		loadInfo.SetActive (false);
		fired = true;
		Rigidbody2D cannonBallInstance = Instantiate (cannonBall, cannonSpawn.position, cannonSpawn.rotation) as Rigidbody2D;
		cannonBallInstance.velocity = currentLaunchForce * cannonSpawn.up;

		currentLaunchForce = minLaunchForce;
	}



}
