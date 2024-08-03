using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointAIwithDelay : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
    public float waitTime = 2f; // Time to wait at each waypoint
    private bool isWaiting = false; // Flag to indicate if the agent is waiting

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    void Update()
    {
        if (!isWaiting && Vector3.Distance(transform.position, target) < 1)
        {
            StartCoroutine(WaitAtWaypoint());
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }

    IEnumerator WaitAtWaypoint()
    {
        // Set the waiting flag
        isWaiting = true;
        // Stop the agent from moving
        agent.isStopped = true;
        // Wait for the specified time
        yield return new WaitForSeconds(waitTime);
        // Iterate to the next waypoint and update the destination
        IterateWaypointIndex();
        UpdateDestination();
        // Resume the agent's movement
        agent.isStopped = false;
        // Reset the waiting flag
        isWaiting = false;
    }
}
