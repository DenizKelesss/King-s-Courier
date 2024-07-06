using UnityEngine;
using UnityEngine.UI;
using Articy.Unity;
using Articy.King_s_Courier.GlobalVariables;

public class EpilogueObjectives : MonoBehaviour
{
    public Text objectiveNameText;

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
        if (ArticyGlobalVariables.Default.Objectives.PressEtoTalk == false)
        {
            objectiveNameText.text = "Talk To The Abyss Master[E]";
        }
        else
        {
            objectiveNameText.text = "Understand";
        }

        if (ArticyGlobalVariables.Default.Objectives.Understand == true)
        {
            objectiveNameText.text = "Open The Void Gate";
        }

        if (ArticyGlobalVariables.Default.Objectives.OpenGate== true)
        {
            objectiveNameText.text = "Into The Void";
        }


    }
}