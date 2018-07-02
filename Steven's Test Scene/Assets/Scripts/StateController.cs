using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour {

    public EnemyStats enemyStats;
    public Transform eyes;

    [HideInInspector] public NavMeshAgent navMeshAgent;
    [HideInInspector] public BoatShooting boatShooting;
    [HideInInspector] public List<Transform> wayPointList;

    public bool aiActive;

	void Awake ()
    {
        boatShooting = GetComponent<BoatShooting>();
        navMeshAgent = GetComponent<NavMeshAgent>();
	}
	
    public void SetupAI(bool aiActivationFromManager, List<Transform> wayPointsFromManager)
    {
        wayPointList = wayPointsFromManager;
        aiActive = aiActivationFromManager;
        if (aiActive)
        {
            navMeshAgent.enabled = true;
        }
        else
        {
            navMeshAgent.enabled = false;
        }
    }
}
