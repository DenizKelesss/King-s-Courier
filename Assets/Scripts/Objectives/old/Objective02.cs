using UnityEngine;
using UnityEngine.UI;
using Articy.Unity;
using Articy.King_s_Courier.GlobalVariables;

public class Objective02 : MonoBehaviour
{
    public Text objectiveNameText;
    public Text objectiveStatusText;

    private bool isObjectiveComplete = false;

    void Start()
    {
        UpdateObjectiveText(); // Call this function at the start of the game
    }

    void Update()
    {
        // Call UpdateObjectiveText whenever the condition changes
        UpdateObjectiveText();
    }

    // Function to update the objective text elements
    void UpdateObjectiveText()
    {
        if (ArticyGlobalVariables.Default.Objectives.OpenGate == true && !isObjectiveComplete)
        {
            objectiveNameText.text = "Open The Void Gate";
            objectiveStatusText.text = "Complete";
            isObjectiveComplete = true; // Set the flag to true indicating the objective is complete
        }
        else if (!isObjectiveComplete)
        {
            objectiveNameText.text = "Open The Void Gate";
            objectiveStatusText.text = "Incomplete";
        }
        else
        {
            // Reset the objective once it's complete
            objectiveNameText.text = "Open The Void Gate";
            objectiveStatusText.text = "Complete";
        }
    }
}
