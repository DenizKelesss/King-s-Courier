using Articy.King_s_Courier.GlobalVariables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSound : MonoBehaviour
{
    public AudioSource teleportSound;

    private void Update()
    {
        if (ArticyGlobalVariables.Default.EventTriggers.CultistLadyGone)
        {
            teleportSound.enabled = true;
        }
    }
}
