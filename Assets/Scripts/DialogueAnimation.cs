using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueAnimation : MonoBehaviour
{
    
    public Text dialogueText;
    public float delay = 0.5f;
    public string[] dialogueLines;
    public int dialogueIndex;
    private bool imTalking;

    void Start()
    {
        Invoke("StartDialogue", 1.5f);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            StopAllCoroutines();
            dialogueText.text = dialogueLines[dialogueIndex];
            dialogueIndex++;
            ShowNextLine();
            
        }
    }
    void  StartDialogue()
    {
       StartCoroutine(ShowText(dialogueLines[dialogueIndex]));
    }

    void ShowNextLine()
    {
     
        if(dialogueIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowText(dialogueLines[dialogueIndex]));
        }
        
    }

    IEnumerator ShowText(string dialogueLine)
    {
        imTalking = true;
        foreach(char letter in dialogueLine)
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(delay);
        }
        dialogueText.text = null; 
        dialogueIndex++;
        ShowNextLine();
    }
}
