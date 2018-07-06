using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour {

    #region Member Variables
    public State currentState;
    public EnemyStats enemyStats;
    public Transform eyes;

    [HideInInspector] public NavMeshAgent navMeshAgent;
    //[HideInInspector] public BoatShooting boatShooting;
    [HideInInspector] public List<Transform> wayPointList;
    [HideInInspector] public int nextWayPoint;

    public bool aiActive;
    #endregion

    void Awake ()
    {       
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

    void Update()
    {
        if (!aiActive)
            return;
        currentState.UpdateState(this);
        
    }

    void OnDrawGizmos()
    {
        if (currentState != null && eyes != null)
        {
            Gizmos.color = currentState.sceneGizmoColor;
            Gizmos.DrawWireSphere(eyes.position, enemyStats.lookSphereCastRadius);
        }
        
    }
}
