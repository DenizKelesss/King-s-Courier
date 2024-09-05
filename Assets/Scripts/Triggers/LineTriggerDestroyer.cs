using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTriggerDestroyer : MonoBehaviour
{
    public GameObject lineTriggerCollider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(lineTriggerCollider);
        }
    }
}
