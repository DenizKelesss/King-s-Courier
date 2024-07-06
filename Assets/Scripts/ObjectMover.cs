using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour, IInteractable
{
    public float moveSpeed = 1.0f; // Speed at which the object moves upwards
    public float targetHeight = 5.0f; // Height to which the object should rise

    private bool isMoving = false; // Flag to check if the object is currently moving

    public void Interact()
    {
        // Check if the object is not already moving
        if (!isMoving)
        {
            StartCoroutine(MoveObject());
            Debug.Log("Interacting with the object!");
            StartCoroutine(MoveObject());
        }
    }

    IEnumerator MoveObject()
    {
        isMoving = true;

        // Get the initial position of the object
        float initialY = transform.position.y;
        float currentY = initialY;

        // Move the object upwards until it reaches the target height
        while (currentY < targetHeight)
        {
            currentY += moveSpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, currentY, transform.position.z);
            yield return null; // Wait for the next frame
        }

        isMoving = false;
    }
}
