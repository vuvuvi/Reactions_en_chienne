using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPath2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator turningPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //turningPlayer.GetBool("isTurned");


            turningPlayer.SetBool("isTurned", false);
        }
    }
}
