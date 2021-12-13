using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PlayerPath : MonoBehaviour
{
    [SerializeField] private Animator turningPlayer;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //turningPlayer.GetBool("isTurned");


            turningPlayer.SetBool("isTurned", true);
        }
    }

}
