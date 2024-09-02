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
    public float targetHeight = 4.0f;


    // Update is called once per frame
    void Update()
    {
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
            // Calculate the distance to the target height
            float distanceToTarget = targetHeight - cultistLadyRunTrigger.position.y;

            // If the object is below the target height, move it upward
            if (distanceToTarget > 0)
            {
                // Move the object upward
                cultistLadyRunTrigger.Translate(Vector3.up * Mathf.Min(moveSpeed * Time.deltaTime, distanceToTarget));
            }
        }
    }
}
