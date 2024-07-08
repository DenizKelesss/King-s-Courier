using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.King_s_Courier.GlobalVariables;

public class Voiceover : MonoBehaviour
{
    public AudioClip Scene1Line1;
    public AudioClip Scene1Line2;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Check if the AudioSource component exists, if not, add one
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ArticyGlobalVariables.Default.VOTriggers.Scene1Line1)
        {
            PlayScene1Line1();
            ArticyGlobalVariables.Default.VOTriggers.Scene1Line1 = false; // Reset the trigger
        }

        if (ArticyGlobalVariables.Default.VOTriggers.Scene1Line2)
        {
            PlayScene1Line2();
            ArticyGlobalVariables.Default.VOTriggers.Scene1Line2 = false;
        }
    }

    void PlayScene1Line1()
    {
        audioSource.clip = Scene1Line1;
        audioSource.Play();
    }

    void PlayScene1Line2()
    {
        audioSource.clip = Scene1Line2;
        audioSource.Play();
    }
}
