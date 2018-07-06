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


    private BoatManager[] b;
    public GameObject[] BoatPrefabs;
    public List<Transform> wayPointsForAI;



    private void SpawnAllBoats()
    {
        b[0].m_Instance = Instantiate(BoatPrefabs[0], b[0].SpawnPoint.position, b[0].SpawnPoint.rotation) as GameObject;
        b[0].PlayerNumber = 1;
       

        
        // Setup the AI tanks

        for (int i = 1; i < b.Length; i++)
        {

            // Create them, set their player number and references needed for control.
            b[i].m_Instance = Instantiate(BoatPrefabs[0], b[0].SpawnPoint.position, b[0].SpawnPoint.rotation) as GameObject;
            b[i].PlayerNumber = i + 1;
            b[i].SetupAI(wayPointsForAI);
        }
    }

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
