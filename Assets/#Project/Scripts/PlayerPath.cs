using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PlayerPath : MonoBehaviour
{
    [SerializeField] private Animator turningPlayer;
    [SerializeField] private Animator turningAgain;



    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //turningPlayer.GetBool("isTurned");
            if (turningPlayer.GetBool("isTurned") == false)
            {
               
                turningPlayer.SetBool("isTurned", true);
                turningAgain.SetBool("Again", false);

            }

            else
            {
                turningAgain.SetBool("Again", true);
                turningPlayer.SetBool("isTurned", false);
            }
            



        }
    }

}
