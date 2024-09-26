using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerLinesManager : MonoBehaviour
{
    public TextMeshProUGUI characterNameText;
    public TextMeshProUGUI dialogueText;
    public GameObject dialogueUI;
    public float autoSkipTime = 4f; // Time to wait before automatically skipping to the next sentence

    private Queue<string> sentences;
    private Coroutine autoSkipCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Line playerLine)
    {
        characterNameText.text = playerLine.name;
        if (dialogueUI != null)
            dialogueUI.SetActive(true);
        sentences.Clear();

        foreach (string sentence in playerLine.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

        // If a coroutine is already running, stop it before starting a new one
        if (autoSkipCoroutine != null)
        {
            StopCoroutine(autoSkipCoroutine);
        }

        // Start the coroutine to automatically skip to the next sentence after a delay
        autoSkipCoroutine = StartCoroutine(DisplayNextSentenceWithDelay(autoSkipTime));
    }

    // Coroutine to wait for autoSkipTime and then display the next sentence
    IEnumerator DisplayNextSentenceWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        DisplayNextSentence();
    }

    public void EndDialogue()
    {
        dialogueUI.SetActive(false);

        // Stop the auto-skip coroutine when dialogue ends
        if (autoSkipCoroutine != null)
        {
            StopCoroutine(autoSkipCoroutine);
        }
    }
}
