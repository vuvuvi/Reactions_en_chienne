using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPC : MonoBehaviour
{

    public Transform ChatBackground;
    public Transform NPCCharacter;

    private dialogueSystem DialogueSystem;

    public string Name;

    
    // Start is called before the first frame update
    void Start()
    {
        DialogueSystem = FindObjectOfType<dialogueSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = Camera.main.WorldToScreenPoint(NPCCharacter.position);
        Pos.y += 175;
        ChatBackground.position = Pos;
    }

    public void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<NPC>().enabled = true;
   
            
    }
        
}
