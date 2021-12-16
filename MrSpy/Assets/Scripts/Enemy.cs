using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //allows Nav Mesh Agent reference in inspector
    public UnityEngine.AI.NavMeshAgent navMeshAgent;

    //array of waypoints
    public Transform[] waypoints;

    //int to track what is the current waypoint
    private int m_CurrentWaypointIndex;


    void Start()
    {
        //set initial destinations of Nav Mesh Agent
        navMeshAgent.SetDestination(waypoints[0].position);

    }

    void Update()
    {
        //check if Nav Mesh Agent has arrived at waypoint destination
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            /*within the limit of the waypoint array update destination to next waypoint remainder operator used
             % which takes whatever is to the left and divides it by the right then returns the remainder. */
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;

            //sets next destination
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);

        }

    }
}
