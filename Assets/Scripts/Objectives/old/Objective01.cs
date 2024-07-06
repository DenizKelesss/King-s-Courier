using UnityEngine;
using UnityEngine.UI;
using Articy.Unity;
using Articy.King_s_Courier.GlobalVariables;
using System.Collections;

public class Objective01 : MonoBehaviour
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
        if (ArticyGlobalVariables.Default.Objectives.PressEtoTalk == true && !isObjectiveComplete)
        {
            StartCoroutine(CompleteObjectiveForDelay("Talk To The Abyss Master(E)", "Complete"));
        }
        else if (!isObjectiveComplete)
        {
            objectiveNameText.text = "Talk To The Abyss Master(E)";
            objectiveStatusText.text = "Incomplete";
        }
        else
        {
            objectiveNameText.text = "Open The Void Gate";
            objectiveStatusText.text = "Incomplete";
        }

        if (ArticyGlobalVariables.Default.Objectives.OpenGate == true)
        {
            objectiveNameText.text = "Open The Void Gate";
            objectiveStatusText.text = "Complete";
        }
    }

    IEnumerator CompleteObjectiveForDelay(string objectiveName, string status)
    {
        objectiveNameText.text = objectiveName;
        objectiveStatusText.text = status;
        isObjectiveComplete = true; // Set the flag to true indicating the objective is complete

        yield return new WaitForSeconds(3f); // Wait for 3 seconds

        // Reset the flag and move to the next objective
        isObjectiveComplete = false;
    }
}
