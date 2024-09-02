using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultLadyRunTrigger : MonoBehaviour
{
    private bool cultLadyRunTriggered;
    public GameObject cultLady;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !cultLadyRunTriggered)
        {
            cultLadyRunTriggered = true;
            StartCoroutine(ActivateCultLady());
        }
    }

    private IEnumerator ActivateCultLady()
    {
        yield return new WaitForEndOfFrame();  // Ensure this runs after all current physics calculations are done.
        cultLady.SetActive(true);
    }
}
