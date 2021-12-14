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
                TurnLeft();

            }

            else
            {
                TurnRight();
            }




        }
    }

    public void TurnLeft()
    {

        turningPlayer.SetBool("isTurned", true);
        turningAgain.SetBool("Again", false);
    }

    public void TurnRight()
    {
        turningAgain.SetBool("Again", true);
        turningPlayer.SetBool("isTurned", false);

    }

}
