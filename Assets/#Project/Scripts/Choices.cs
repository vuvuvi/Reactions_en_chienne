using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Choices : MonoBehaviour
{
    [SerializeField] private Animator animator;
    // Start is called before the first frame update

    public void TurnPlayer()
    {

        animator.SetBool("PlayTurn", true);
    }
   

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            animator.SetBool("PlayTurn", false);

        }
    }
}
