using UnityEngine;
using UnityEngine.UI;

public class NPCInteraction : MonoBehaviour
{
    public GameObject interactionPrompt; // Reference to the UI text
    private bool isPlayerInRange = false;

    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Talk();
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
            interactionPrompt.SetActive(false); // Hide the prompt
        }
    }

    private void Talk()
    {
        Debug.Log("Talking to NPC...");
        // Add your conversation logic here
        interactionPrompt.SetActive(false); // Hide the prompt

    }
}
