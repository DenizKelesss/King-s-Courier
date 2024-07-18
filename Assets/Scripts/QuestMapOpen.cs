using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestMapOpen : MonoBehaviour
{

    private bool isPlayerInRange = false;
    public GameObject QuestMap;

    private void Update()
    {
        if(isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            QuestMap.SetActive(true);
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
            QuestMap.SetActive(false); // Hide
        }
    }

}
