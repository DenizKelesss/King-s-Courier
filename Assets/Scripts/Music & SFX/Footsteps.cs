using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footStepsSource;
    private bool isGrounded = true;

    private void Update()
    {
        if (isGrounded && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        { 
            footStepsSource.enabled = true;
        }
        else
        {
            footStepsSource.enabled = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            footStepsSource.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Player is grounded
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false; // Player is grounded
        }
    }
}
