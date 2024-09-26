using Articy.King_s_Courier.GlobalVariables;
using UnityEngine;

public class DoubleGateClickOpen : MonoBehaviour
{
    public Transform leftGate;  // Reference to the left gate object
    public Transform rightGate; // Reference to the right gate object
    public float rotationSpeed = 30.0f; // Speed at which the gates rotate
    public float targetAngle = 90.0f; // Angle to which the gates should open

    private bool isMoving = false;
    private float currentAngle = 0.0f;
    private bool isPlayerInRange = false;
    private bool isOpen = false; // Track whether the gate is open or closed

    void Update()
    {
        // Check for the player being in range and pressing 'E'
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            isMoving = true;
        }

        // If the gates are in motion, rotate them
        if (isMoving)
        {
            RotateGates();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }

    void RotateGates()
    {
        // Check if the gates are assigned
        if (leftGate != null && rightGate != null)
        {
            // Calculate the rotation step for this frame
            float rotationStep = rotationSpeed * Time.deltaTime;

            if (!isOpen)
            {
                // Opening the gates
                leftGate.Rotate(Vector3.up, rotationStep);
                rightGate.Rotate(Vector3.up, -rotationStep);
                currentAngle += rotationStep;

                // Stop once the gates reach the target angle
                if (currentAngle >= targetAngle)
                {
                    leftGate.localEulerAngles = new Vector3(leftGate.localEulerAngles.x, targetAngle, leftGate.localEulerAngles.z);
                    rightGate.localEulerAngles = new Vector3(rightGate.localEulerAngles.x, -targetAngle, rightGate.localEulerAngles.z);
                    isOpen = true;  // Gates are now open
                    isMoving = false;
                    currentAngle = 0.0f; // Reset current angle for closing
                }
            }
            else
            {
                // Closing the gates
                leftGate.Rotate(Vector3.up, -rotationStep);
                rightGate.Rotate(Vector3.up, rotationStep);
                currentAngle += rotationStep;

                // Stop once the gates reach the closed position
                if (currentAngle >= targetAngle)
                {
                    leftGate.localEulerAngles = new Vector3(leftGate.localEulerAngles.x, 0, leftGate.localEulerAngles.z);
                    rightGate.localEulerAngles = new Vector3(rightGate.localEulerAngles.x, 0, rightGate.localEulerAngles.z);
                    isOpen = false;  // Gates are now closed
                    isMoving = false;
                    currentAngle = 0.0f; // Reset current angle for opening
                }
            }
        }
        else
        {
            Debug.LogError("Left or Right gate to rotate is not assigned.");
        }
    }
}
