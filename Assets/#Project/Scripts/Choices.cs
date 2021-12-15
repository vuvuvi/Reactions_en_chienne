using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Rendering.PostProcessing;


public class Choices : MonoBehaviour
{

    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    public PostProcessVolume volume;
    
    private Vignette vignette;
    private LensDistortion lensDistortion;

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


    public void isStressed()
    {
        volume.isGlobal = true;
    }

    public void StressIntensifying()
    {
       vignette = volume.profile.GetSetting<Vignette>();
       vignette.intensity.value += 0.1f;
        lensDistortion = volume.profile.GetSetting<LensDistortion>();
        lensDistortion.intensity.value -= 1.0f;
    }

    public void StressDetensifying()
    {
        vignette = volume.profile.GetSetting<Vignette>();
        vignette.intensity.value -= 0.1f;
        lensDistortion = volume.profile.GetSetting<LensDistortion>();
        lensDistortion.intensity.value += 1.0f;
    }



}
