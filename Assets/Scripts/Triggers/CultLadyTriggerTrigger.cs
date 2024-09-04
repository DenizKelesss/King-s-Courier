using Articy.King_s_Courier.GlobalVariables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.King_s_Courier;

public class CultLadyTriggerTrigger : MonoBehaviour
{
    //public GameObject cultistLady;
    public Transform cultistLadyRunTrigger;
    public float moveSpeed = 3.0f;
    public float targetHeight = 11.0f;

    // Update is called once per frame
    void Update()
    {
        if (ArticyGlobalVariables.Default.EventTriggers.CultistLadyRun)
        {
            moveTriggerUp();
        }
    }

    void moveTriggerUp()
    {
        if (cultistLadyRunTrigger != null && cultistLadyRunTrigger.position.y < targetHeight)
        {
            float moveDistance = moveSpeed * Time.deltaTime;
            cultistLadyRunTrigger.Translate(Vector3.up * Mathf.Min(moveDistance, targetHeight - cultistLadyRunTrigger.position.y));
        }
    }
}
