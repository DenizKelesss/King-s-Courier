using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footStepsSource;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        { 
            footStepsSource.enabled = true;
        }
        else
        {
            footStepsSource.enabled = false;
        }
    }
}
