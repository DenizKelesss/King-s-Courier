using Articy.King_s_Courier.GlobalVariables;
using UnityEngine;

public class CultLadyGoneTrigger : MonoBehaviour
{
    public GameObject cultLady;
    private PlayerController playerController;

    void Start()
    {
        // Find the PlayerController
        playerController = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ArticyGlobalVariables.Default.EventTriggers.CultistLadyGone)
        {
            Destroy(cultLady, 2);  // Destroy the cult lady after 2 seconds

            // Check if availableDialogue is referencing the destroyed NPC and clear it
            if (playerController.availableDialogue != null)
            {
                playerController.availableDialogue = null;
            }
        }
    }
}
