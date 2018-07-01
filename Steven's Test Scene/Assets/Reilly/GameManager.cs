using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	private Swap swap;

	public GameObject canvas;

	public Camera camera;

	public Light light;

	public GameObject even;

	public Button testButton;

	public Button stevenButton;

	void Start()
	{
		Instantiate (canvas);
		Instantiate (camera);
		Instantiate (light);
		Instantiate (even);

		GameObject controller = GameObject.FindGameObjectWithTag ("Controller");
		swap = controller.GetComponent<Swap> ();

		GameObject krisButton = GameObject.FindGameObjectWithTag ("Kris Button");
		Button kButton = krisButton.GetComponent<Button> ();
		kButton.onClick.AddListener(delegate {swap.ChangeScene("Kris_Test");});

		GameObject mainButton = GameObject.FindGameObjectWithTag ("Steven Button");
		Button sButton = mainButton.GetComponent<Button> ();
		sButton.onClick.AddListener(delegate {swap.ChangeScene("Main");});
	}
}
