using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractions : MonoBehaviour
{

    public GameObject interactionPrompt; // Reference to the UI text
    public GameObject interactionText;
    private bool isPlayerInRange = false;
    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Inspect();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            interactionPrompt.SetActive(true); // Show the prompt
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            interactionPrompt.SetActive(false); // Show the prompt
        }
    }
    // Start is called before the first frame update
    private void Inspect()
    {
        interactionPrompt.SetActive(false);
        interactionText.SetActive(true);
    }

}
