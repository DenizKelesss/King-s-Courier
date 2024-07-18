using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLinesManager : MonoBehaviour
{
    public TextMeshProUGUI characterNameText;
    public TextMeshProUGUI dialogueText;
    public GameObject dialogueUI;

    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences= new Queue<string>();
    }

    public void StartDialogue (Line playerLine)
    {
        characterNameText.text = playerLine.name;
        if(dialogueUI  != null)
            dialogueUI.SetActive(true);
        sentences.Clear();

        foreach (string sentence in playerLine.sentences) 
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0) 
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    public void EndDialogue ()
    {
        Destroy(dialogueUI); // dialogueUI.SetActive(false) --> could work better.
    }


}
