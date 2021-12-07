using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Choices : MonoBehaviour
{

    [SerializeField] private Animator animator;
    // Start is called before the first frame update

    public Transform cameraRotation;
    public void TurnPlayer()
    {
        //animator.SetBool("PlayTurn", true);
        animator.SetTrigger("Play Turn Around");
    }

    public void MakePlayerLookDown(float angle) {
        cameraRotation.Rotate(Vector3.right, angle);
    }


    private void OnTriggerExit(Collider other)
    {
        // if (other.CompareTag("Player"))
        // {

        //     animator.SetBool("PlayTurn", false);

        // }
    }

    private void RotationDown(Transform transform)
    {
        cameraRotation = transform;
    }
}
