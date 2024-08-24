using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class HeadAimTrigger : MonoBehaviour
{
    public RigBuilder Rig1;
    private bool isPlayerInRange = false;

    private void Start()
    {
        Rig1 = GetComponent<RigBuilder>();
        if (Rig1 == null)
        {
            Debug.LogError("RigBuilder component not found on the GameObject.");
        }
    }
    private void Update()
    {
        if (isPlayerInRange)
        {
            Rig1.enabled = true;
            Debug.Log("Player entered trigger zone.");

        }
        else
        {
            Rig1.enabled = false;
            Debug.Log("Player exited trigger zone.");

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

}
