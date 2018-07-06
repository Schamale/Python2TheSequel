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
    #region Constructors

    /// <summary>
    /// Get's the NavMeshAgent Component off of the boat
    /// </summary>
    void Awake ()
    {       
        navMeshAgent = GetComponent<NavMeshAgent>();
	}

    #region Default Constructor 

    /// <summary>
    /// This Constructor sets up the ai and makes sure it is Active and sets up way points so that it can patrol them and enables the boats navMeshAgent
    /// </summary>
    /// <param name="aiActivationFromManager"> This checks if the AI is Active </param>
    /// <param name="wayPointsFromManager"> This is in Game Manager and will be a list of waypoints for the ai to Patrol </param>
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
    #endregion

    /// <summary>
    /// updates the ai to the current state.
    /// </summary>
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
            //Gizmos.DrawWireSphere(eyes.position, enemyStats.lookSphereCastRadius);
        }
        
    }
    #endregion
}
