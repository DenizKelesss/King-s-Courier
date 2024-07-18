using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LineTrigger : MonoBehaviour
{
    public Line playerLine;

   public void TriggerDialogue ()
    {
        FindObjectOfType<PlayerLinesManager>().StartDialogue(playerLine);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            FindObjectOfType<PlayerLinesManager>().StartDialogue(playerLine);
    }

}
