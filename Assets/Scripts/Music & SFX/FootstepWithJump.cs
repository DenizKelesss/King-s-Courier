using System.Collections;
using UnityEngine;

public class FootstepsWithJump : MonoBehaviour
{
    public AudioSource footStepsSource;
    private bool isJumping = false;

    private void Update()
    {
        // Check if the player is jumping
        if (isJumping)
        {
            return; // Do nothing if jumping to avoid overriding the footstep state
        }

        // Enable or disable footstep sounds based on movement keys
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footStepsSource.enabled = true;
        }
        else
        {
            footStepsSource.enabled = false;
        }

        // Trigger the jump logic
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(DisableFootstepsForDuration(0.7f));
        }
    }

    private IEnumerator DisableFootstepsForDuration(float duration)
    {
        isJumping = true;
        footStepsSource.enabled = false;
        yield return new WaitForSeconds(duration);
        isJumping = false;
    }
}
