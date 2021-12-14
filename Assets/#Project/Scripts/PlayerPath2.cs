using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPath2 : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] public Animator turningAgain;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //turningPlayer.GetBool("isTurned");

            TurnRight();

        }
    }

    public void TurnRight()
    {
        
        turningAgain.SetBool("Again", true);

    }
}
