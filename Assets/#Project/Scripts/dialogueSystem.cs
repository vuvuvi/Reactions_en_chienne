using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dialogueSystem : MonoBehaviour
{
    // Start is called before the first frame update
    private static DialogueManager instance;
    public static DialogueManager GetInstance()
    {
        return instance;
    }
    // Update is called once per frame
    private void OnMouseDown()
    {
        DialogueManager.GetInstance().ExitDialogueMode();
    }
}
