using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueMusicPlay : MonoBehaviour
{
    private void Awake()
    {
        // Find all game objects tagged as "IntroMusic"
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("IntroMusic");

        // If there is more than one "IntroMusic" object, destroy this one to avoid duplicates
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            // Ensure the music object persists across scene loads
            DontDestroyOnLoad(this.gameObject);

            // Subscribe to the sceneLoaded event
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Check if the current scene is the main menu (scene 0)
        if (scene.buildIndex == 0)
        {
            Destroy(this.gameObject); // Destroy the music object if in scene 0
        }
    }

    private void OnDestroy()
    {
        // Unsubscribe from the sceneLoaded event when the object is destroyed
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
