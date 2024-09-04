using Articy.King_s_Courier.GlobalVariables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultLadyGoneTrigger : MonoBehaviour
{
    public GameObject cultLady;


    // Update is called once per frame
    void Update()
    {
        if (ArticyGlobalVariables.Default.EventTriggers.CultistLadyGone)
        {
            Destroy(cultLady, 2);
        }
    }
}
