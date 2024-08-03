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
    }
    private void Update()
    {
        if (isPlayerInRange)
        {
            Rig1.enabled = true;
        }
        else
        {
            Rig1.enabled = false;
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
