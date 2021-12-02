using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class DialogueTrigger : MonoBehaviour
{

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    [SerializeField] private UnityEvent actions0;
    [SerializeField] private UnityEvent actions1;
    [SerializeField] private UnityEvent actions2;
    private bool playerInRange;
    public AudioSource sound;
    

    private void Awake()
    {
        
        playerInRange = false;
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            
            DialogueManager.GetInstance().EnterDialogueMode(inkJSON, this);

            
            playerInRange = false;
            
        }
        else
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            sound.Play();
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInRange = false;
            
        }
    }

    public void StartAnimation(int reaction)
    {
        print(reaction);
        if (reaction == 0)
        {
            actions0?.Invoke();
        }
        if (reaction == 1)
        {
            actions1?.Invoke();
        }

        if (reaction == 2)
        {
            actions2?.Invoke();
        }



    }


}
