﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Action/Patrol")]
public class PatrolAction : Action
{

    public override void Act(StateController stateController)
    {
        
    }
    
    private void Patrol (StateController controller)
    {
        controller.navMeshAgent.destination = controller.wayPointList [controller.nextWayPoint].position;
        controller.navMeshAgent.isStopped = false;

        if (controller.navMeshAgent.remainingDistance <= controller.navMeshAgent.stoppingDistance && !controller.navMeshAgent.pathPending)
        {
            controller.nextWayPoint = (controller.nextWayPoint + 1) % controller.wayPointList.Count;
        }
    }
}
