using Articy.King_s_Courier.GlobalVariables;
using UnityEngine;

public class FallGateOpenTrigger : MonoBehaviour
{
    public Transform objectToMove; // Reference to the object you want to move
    public float moveSpeed = 3.0f; // Speed at which the object moves upward
    public float targetHeight = 15.0f; // Height to which the object should rise

    void Update()
    {
        if (ArticyGlobalVariables.Default.FallGate.FallGateOpen)
        {
            MoveObjectUpward();
        }
    }

    void MoveObjectUpward()
    {
        // Check if the object to move is assigned
        if (objectToMove != null)
        {
            // Calculate the distance to the target height
            float distanceToTarget = targetHeight - objectToMove.position.y;

            // If the object is below the target height, move it upward
            if (distanceToTarget > 0)
            {
                // Move the object upward
                objectToMove.Translate(Vector3.up * Mathf.Min(moveSpeed * Time.deltaTime, distanceToTarget));
            }
        }
        else
        {
            Debug.LogError("Object to move is not assigned.");
        }
    }
}
