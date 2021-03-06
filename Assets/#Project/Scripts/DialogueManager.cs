using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    private Story currentStory;
    private DialogueTrigger dialogueTrigger;
    public bool dialogueIsPlaying { get; set; }
    //public Animation reactions;

    private static DialogueManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Found more than one");
        }
        instance = this;
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0; 
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update()
    {
        //if (!dialogueIsPlaying)
        //{
        //    return;
        //}

        //else
        //{
        //    ContinueStory();
        //}


    }

    public void EnterDialogueMode(TextAsset inkJSON, DialogueTrigger dialogue)
    {
        dialogueTrigger = dialogue;
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        ContinueStory();

    }

    public void ExitDialogueMode()
    {
        print("test");
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
        
    }

     private void ContinueStory()

    {
        if (currentStory.canContinue)
        {
           
            dialogueText.text = currentStory.Continue();
            DisplayChoices();
 
        }
        else
        {
            ExitDialogueMode();

        }

    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count < choices.Length)
        {
            Debug.LogError("BRRRR");
        }

        int index = 0;
        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
            
            //reactions.Play();

        }

        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());


    }

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        dialogueIsPlaying = false;
        dialogueTrigger.StartAnimation(choiceIndex);
    }
}
