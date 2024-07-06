using Articy.King_s_Courier.GlobalVariables;
using Articy.Unity;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveDefiner : MonoBehaviour
{
    public Text objectiveNameText;
    public Text objectiveStatusText;

    // Store the previous states of the objectives
    private bool previousObjective1State;
    private bool previousObjective2State;

    void Start()
    {
        // Initialize previous states of objectives
        previousObjective1State = ArticyGlobalVariables.Default.Objectives.PressEtoTalk;
        previousObjective2State = ArticyGlobalVariables.Default.Objectives.OpenGate;

        // Update UI based on initial states
        UpdateUI();
    }

    void Update()
    {
        // Check if the state of objectives has changed
        if (ArticyGlobalVariables.Default.Objectives.PressEtoTalk != previousObjective1State ||
            ArticyGlobalVariables.Default.Objectives.OpenGate != previousObjective2State)
        {
            // Update previous states
            previousObjective1State = ArticyGlobalVariables.Default.Objectives.PressEtoTalk;
            previousObjective2State = ArticyGlobalVariables.Default.Objectives.OpenGate;

            // Update UI based on new states
            UpdateUI();
        }
    }

    // Update UI based on the current state of objectives
    void UpdateUI()
    {
        if (previousObjective1State)
        {
            objectiveNameText.text = "Press E";
            objectiveStatusText.text = "Complete";
        }
        else if (previousObjective2State)
        {
            objectiveNameText.text = "Open Gate";
            objectiveStatusText.text = "Complete";
        }
        else
        {
            objectiveNameText.text = "No Objective";
            objectiveStatusText.text = "Incomplete";
        }
    }
}
