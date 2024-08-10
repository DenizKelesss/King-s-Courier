using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointAIStoppable : MonoBehaviour
{
    NavMeshAgent agent;
    private bool isPlayerInRange = false;
    private bool shouldMove = true; // Variable to control movement
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    void Update()
    {
        if (shouldMove)
        {
            // Check if close to the target and update destination if needed
            if (Vector3.Distance(transform.position, target) < 1)
            {
                IterateWaypointIndex();
                UpdateDestination();
            }
        }

        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (shouldMove)
            {
                StopMovement();
            }
            else
            {
                ContinueMovement();
            }
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

    void StopMovement()
    {
        shouldMove = false;
        agent.isStopped = true;
        Debug.Log("Movement stopped");
    }

    void ContinueMovement()
    {
        shouldMove = true;
        agent.isStopped = false;
        UpdateDestination(); // Ensure agent continues towards the target
        Debug.Log("Movement continued");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("Player in range");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("Player out of range");

            // Restart movement if the NPC was stopped
            if (!shouldMove)
            {
                ContinueMovement();
            }
        }
    }
}
