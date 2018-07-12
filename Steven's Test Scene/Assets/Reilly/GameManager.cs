using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	private Swap swap;
	public GameObject canvas;
	public Camera camera;
	public Light light;
	public GameObject even;
	public Button testButton;
	public Button stevenButton;


    public BoatManager[] Boats;
    public GameObject[] BoatPrefabs;
    public List<Transform> wayPointsForAI;



    private void SpawnAllBoats()
    {
        Boats[0].m_Instance = Instantiate(BoatPrefabs[0], Boats[0].SpawnPoint.position, Boats[0].SpawnPoint.rotation) as GameObject;
        Boats[0].PlayerNumber = 1;



        // Setup the AI boats

        for (int i = 1; i < Boats.Length; i++)
        {

            // Create them, set their player number and references needed for control.
            Boats[i].m_Instance = Instantiate(BoatPrefabs[0], Boats[0].SpawnPoint.position, Boats[0].SpawnPoint.rotation) as GameObject;
            Boats[i].PlayerNumber = i + 1;
            Boats[i].SetupAI(wayPointsForAI);
        }
    }

    void Start()
	{
        SpawnAllBoats();
		//Instantiate (canvas);
		//Instantiate (camera);
		//Instantiate (light);
		//Instantiate (even);

		//GameObject controller = GameObject.FindGameObjectWithTag ("Controller");
		//swap = controller.GetComponent<Swap> ();

		//GameObject krisButton = GameObject.FindGameObjectWithTag ("Kris Button");
		//Button kButton = krisButton.GetComponent<Button> ();
		//kButton.onClick.AddListener(delegate {swap.ChangeScene("Kris_Test");});

		//GameObject mainButton = GameObject.FindGameObjectWithTag ("Steven Button");
		//Button sButton = mainButton.GetComponent<Button> ();
		//sButton.onClick.AddListener(delegate {swap.ChangeScene("Main");});
	}
}
