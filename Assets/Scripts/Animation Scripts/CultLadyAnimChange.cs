using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultLadyAnimChange : MonoBehaviour
{

    public Animator CultLadyAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CultLady"))
        {
            CultLadyAnimator.SetBool("pray", true);
        }
    }

}
