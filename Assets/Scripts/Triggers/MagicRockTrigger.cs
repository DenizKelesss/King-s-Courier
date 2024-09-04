using Articy.King_s_Courier.GlobalVariables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.King_s_Courier;

public class MagicRockTrigger : MonoBehaviour
{
    public Transform magicRock;
    public float moveSpeed = 3.0f;
    public float targetHeight = 7.0f;

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
        if (magicRock != null && magicRock.position.y < targetHeight)
        {
            float moveDistance = moveSpeed * Time.deltaTime;
            magicRock.Translate(Vector3.up * Mathf.Min(moveDistance, targetHeight - magicRock.position.y));
        }
    }
}
