using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Articy.Unity;
using Articy.King_s_Courier.GlobalVariables;

public class Reputation : MonoBehaviour
{
    public Text ReputationAmount;
    private int lastReputationScore;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the reputation score from Articy global variable
        lastReputationScore = ArticyGlobalVariables.Default.KingdomReputation.KingdomRep;
        UpdateReputationUI(lastReputationScore);

        // Start the coroutine to periodically check for reputation changes
        StartCoroutine(CheckReputationChange());
    }

    // Coroutine to periodically check for reputation changes
    IEnumerator CheckReputationChange()
    {
        while (true)
        {
            // Wait for a short period before checking again
            yield return new WaitForSeconds(1f);

            // Retrieve the updated reputation score from Articy
            int updatedReputationScore = ArticyGlobalVariables.Default.KingdomReputation.KingdomRep;

            // If the reputation score has changed, update the UI
            if (updatedReputationScore != lastReputationScore)
            {
                lastReputationScore = updatedReputationScore;
                UpdateReputationUI(updatedReputationScore);
            }
        }
    }

    // Method to update the reputation UI
    void UpdateReputationUI(int reputationScore)
    {
        ReputationAmount.text = reputationScore.ToString();
    }
}
