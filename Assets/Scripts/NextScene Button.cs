using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Articy.Unity;
using Articy.King_s_Courier.GlobalVariables;

public class NextSceneButton : MonoBehaviour
{
    public GameObject cultLadyNotDoneText;
    public GameObject LordPhilippeNotDoneText;
    public GameObject sceneTasksNotDoneText;
    public GameObject backButton;
    public GameObject QuestMap;

    public void NextScene()
    {
        if (ArticyGlobalVariables.Default.Scene1Finishing.CultLadyDone && ArticyGlobalVariables.Default.Scene1Finishing.LordPhilppeDone)
        {
            SceneManager.LoadSceneAsync(2);
        }
        else
        {
            if (!(ArticyGlobalVariables.Default.Scene1Finishing.CultLadyDone) && ArticyGlobalVariables.Default.Scene1Finishing.LordPhilppeDone)
            {
                cultLadyNotDoneText.SetActive(true);
                StartCoroutine(DeactivateAfterDelay(cultLadyNotDoneText, 4f));
            }
            if (ArticyGlobalVariables.Default.Scene1Finishing.CultLadyDone && !(ArticyGlobalVariables.Default.Scene1Finishing.LordPhilppeDone))
            {
                LordPhilippeNotDoneText.SetActive(true);
                StartCoroutine(DeactivateAfterDelay(LordPhilippeNotDoneText, 4f));
            }
            if (!(ArticyGlobalVariables.Default.Scene1Finishing.CultLadyDone) && !(ArticyGlobalVariables.Default.Scene1Finishing.LordPhilppeDone))
            {
                sceneTasksNotDoneText.SetActive(true);
                StartCoroutine(DeactivateAfterDelay(sceneTasksNotDoneText, 4f));
            }
        }
    }

    IEnumerator DeactivateAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        obj.SetActive(false);
    }

    public void BackButtonClicked()
    {
        cultLadyNotDoneText.SetActive(false);
        LordPhilippeNotDoneText.SetActive(false);
        sceneTasksNotDoneText.SetActive(false);
        QuestMap.SetActive(false);



    }

}