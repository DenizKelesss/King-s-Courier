using UnityEngine;
using UnityEngine.UI;
using Articy.Unity;
using Articy.King_s_Courier.GlobalVariables;

public class Chapter1Objectives : MonoBehaviour
{
    public Text objectiveNameText;

    void Start()
    {
        UpdateChapter1ObjectiveText(); // Call this function at the start of the game
    }

    void Update()
    {
        // Call UpdateObjectiveText whenever the condition changes
        UpdateChapter1ObjectiveText();
    }

    // Function to update the objective text elements
    void UpdateChapter1ObjectiveText()
    {
        if (ArticyGlobalVariables.Default.Objectives.TalkToLadyU == false)
        {
            objectiveNameText.text = "Talk To Lady Umbress";
        }
        else
        {
            objectiveNameText.text = "No Objectives";
        }

      //  if (ArticyGlobalVariables.Default.Objectives.Understand == true)
        {
       //     objectiveNameText.text = "Open The Void Gate";
        }

     //   if (ArticyGlobalVariables.Default.Objectives.OpenGate== true)
        {
       //     objectiveNameText.text = "Into The Void";
        }


    }
}