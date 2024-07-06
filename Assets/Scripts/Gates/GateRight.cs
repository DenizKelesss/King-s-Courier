using Articy.King_s_Courier.GlobalVariables;
using UnityEngine;

public class GateRight : MonoBehaviour
{
    public Transform gate; // Reference to the gate object you want to rotate
    public float rotationSpeed = 30.0f; // Speed at which the gate rotates
    public float targetAngle = 90.0f; // Angle to which the gate should open

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
            RotateGate();
        }
    }

    void RotateGate()
    {
        // Check if the gate to rotate is assigned
        if (gate != null)
        {
            // Calculate the rotation step for this frame
            float rotationStep = rotationSpeed * Time.deltaTime;

            // Rotate the gate rightwards (negative y-axis direction)
            gate.Rotate(Vector3.up, -rotationStep);

            // Update the current angle
            currentAngle += rotationStep;

            // Check if the gate has reached the target angle
            if (currentAngle >= targetAngle)
            {
                // Clamp the rotation to the target angle
                gate.localEulerAngles = new Vector3(gate.localEulerAngles.x, -targetAngle, gate.localEulerAngles.z);
                isOpening = false; // Stop rotating once the target angle is reached
            }
        }
        else
        {
            Debug.LogError("Gate to rotate is not assigned.");
        }
    }
}