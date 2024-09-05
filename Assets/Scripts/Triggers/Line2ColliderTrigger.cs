using Articy.King_s_Courier.GlobalVariables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.King_s_Courier;

public class Line2ColliderTrigger : MonoBehaviour
{
    //public GameObject cultistLady;
    public Transform Line2Collider;
    public float moveSpeed = 6.0f;
    public float targetHeight = 6.5f;

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
        if (Line2Collider != null && Line2Collider.position.y < targetHeight)
        {
            float moveDistance = moveSpeed * Time.deltaTime;
            Line2Collider.Translate(Vector3.up * Mathf.Min(moveDistance, targetHeight - Line2Collider.position.y));
        }
    }
}
