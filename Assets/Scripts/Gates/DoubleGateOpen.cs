using Articy.King_s_Courier.GlobalVariables;
using UnityEngine;

public class DoubleGateOpen : MonoBehaviour
{
    public Transform leftGate;  // Reference to the left gate object
    public Transform rightGate; // Reference to the right gate object
    public float rotationSpeed = 30.0f; // Speed at which the gates rotate
    public float targetAngle = 90.0f; // Angle to which the gates should open

    private bool isOpening = false;
    private float currentAngle = 0.0f;

    void Update()
    {
        if (ArticyGlobalVariables.Default.FallGate.FallGateOpen && !isOpening)
        {
            isOpening = true;
        }

        if (isOpening)
        {
            RotateGates();
        }
    }

    void RotateGates()
    {
        // Check if the gates to rotate are assigned
        if (leftGate != null && rightGate != null)
        {
            // Calculate the rotation step for this frame
            float rotationStep = rotationSpeed * Time.deltaTime;

            // Rotate the left gate
            leftGate.Rotate(Vector3.up, rotationStep);

            // Rotate the right gate in the opposite direction
            rightGate.Rotate(Vector3.up, -rotationStep);

            // Update the current angle
            currentAngle += rotationStep;

            // Check if the gates have reached the target angle
            if (currentAngle >= targetAngle)
            {
                // Clamp the rotation to the target angle
                leftGate.localEulerAngles = new Vector3(leftGate.localEulerAngles.x, targetAngle, leftGate.localEulerAngles.z);
                rightGate.localEulerAngles = new Vector3(rightGate.localEulerAngles.x, -targetAngle, rightGate.localEulerAngles.z);
                isOpening = false; // Stop rotating once the target angle is reached
            }
        }
        else
        {
            Debug.LogError("Left or Right gate to rotate is not assigned.");
        }
    }
}
