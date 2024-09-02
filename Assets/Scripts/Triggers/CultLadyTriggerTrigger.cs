using Articy.King_s_Courier.GlobalVariables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.King_s_Courier;

public class CultLadyTriggerTrigger : MonoBehaviour
{
    //public GameObject cultistLady;
    public Transform cultistLadyRunTrigger;
    public float moveSpeed = 3.0f;
    public float targetHeight = 11.0f;

    // Update is called once per frame
    void Update()
    {
        // Log the current state of the global variable
        Debug.Log("CultistLadyRun: " + ArticyGlobalVariables.Default.EventTriggers.CultistLadyRun);

        // Log the call of the Update method
        Debug.Log("Update method called.");

        if (ArticyGlobalVariables.Default.EventTriggers.CultistLadyRun)
        {
            moveTriggerUp();
        }
    }

    void moveTriggerUp()
    {
        // Check if the object to move is assigned
        if (cultistLadyRunTrigger != null)
        {
            // Log the current position of the trigger
            Debug.Log("Current Position: " + cultistLadyRunTrigger.position.y);

            // Calculate the distance to the target height
            float distanceToTarget = targetHeight - cultistLadyRunTrigger.position.y;

            // Log the distance to the target
            Debug.Log("Distance to Target: " + distanceToTarget);

            // If the object is below the target height, move it upward
            if (distanceToTarget > 0)
            {
                // Log the movement action
                Debug.Log("Moving trigger up");

                // Move the object upward
                cultistLadyRunTrigger.Translate(Vector3.up * Mathf.Min(moveSpeed * Time.deltaTime, distanceToTarget));

                // Log the new position of the trigger
                Debug.Log("New Position: " + cultistLadyRunTrigger.position.y);
            }
        }
        else
        {
            // Log a warning if the trigger is not assigned
            Debug.LogWarning("cultistLadyRunTrigger is not assigned!");
        }
    }
}
