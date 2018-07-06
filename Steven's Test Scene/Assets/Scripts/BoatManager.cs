using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BoatManager : MonoBehaviour {

    public Color PlayerColor;                               // This is the color this boat will be tinted.
    public Transform SpawnPoint;                            // The position and direction the boat will have when it spawns.
    [HideInInspector] public GameObject m_Instance;         // A reference to the of the boat when it is created.
    [HideInInspector] public List<Transform> m_WayPointList;// List of waypoint's for Boats to patrol.
    [HideInInspector] public int PlayerNumber;              // This specifies which player this is

    private StateController controller;                     // Reference to the StateController for AI.
    



    public void SetupAI(List<Transform> wayPointList)
    {
        controller = m_Instance.GetComponent<StateController>();
        controller.SetupAI(true, wayPointList);


        SpriteRenderer[] renderers = m_Instance.GetComponentsInChildren<SpriteRenderer>();

        for (int i = 0; i < renderers.Length; i++)
        {
            renderers[i].material.color = PlayerColor;
        }
    }

    public void EnableControl ()
    {
        if (controller != null)
            controller.enabled = true;
    }

    public void Reset()
    {
        m_Instance.transform.position = SpawnPoint.position;
        m_Instance.transform.rotation = SpawnPoint.rotation;

        m_Instance.SetActive(false);
        m_Instance.SetActive(true);
    }


}
