using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SophieAnimationScript : MonoBehaviour
{
    public Animator sophieAnimator;
    public InMemoryVariableStorage yarnInMemoryStorage;

    //Stops Sophies walk if the Player is close by
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            sophieAnimator.Play("Female Stop Walking");
        }
    }
    
    //Starts Sophies walk again once player has left
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            sophieAnimator.Play("Walking 0");

        }
    }

    [YarnCommand("sophie_animation_selector")]
    public void SophieAnimationSelector()
    {
        string sophieAnimation;
        yarnInMemoryStorage.TryGetValue("$sophieAnimation", out sophieAnimation);

        if (sophieAnimation == "Slap")
        {
            sophieAnimator.Play("Female Slap");
        }

        if (sophieAnimation == "StopWalking")
        {
            sophieAnimator.Play("Female Stop Walking");
        }

        if (sophieAnimation == "Happy")
        {
            sophieAnimator.Play("Excited");
        }

        if (sophieAnimation == "Walking")
        {
            sophieAnimator.Play("Walking");
        }
    }
   
}
