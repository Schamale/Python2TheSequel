using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName =  "PluggableAI/State")]
public class State : ScriptableObject
{
    #region Member Variables 
    public Action[] actions;
    public Color sceneGizmoColor = Color.gray;
    #endregion

    /// <summary>
    /// puts the actions in a array 
    /// </summary>
    /// <param name="controller"> </param>
    /// 
    #region constructor
    public void UpdateState (StateController controller)
    {
        DoActions(controller);
    }
    #endregion

    #region default Constructor 
    private void DoActions (StateController controller)
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Act(controller);
        }
    }
    #endregion
}
