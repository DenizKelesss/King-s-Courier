using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimationInteract : MonoBehaviour
{
    public Animator interactableanimator;
    private bool isPlayerInRange = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerInRange)
        {
            interactableanimator.SetBool("Talk 0", true);
        }
        else if (!(isPlayerInRange))
        {
            interactableanimator.SetBool("Talk 0", false);
        }
    }
}
