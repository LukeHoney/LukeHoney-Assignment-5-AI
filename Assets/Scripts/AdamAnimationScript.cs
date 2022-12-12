using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class AdamAnimationScript : MonoBehaviour
{
    public Animator adamAnimator;

    public InMemoryVariableStorage yarnInMemoryStorage;

    //Changes Adam's animation depending on yarn values

    [YarnCommand("adam_animation_selector")]
    public void AdamAnimationSelector()
    {
        string AdamEmotion;
        yarnInMemoryStorage.TryGetValue("$AdamEmotion", out AdamEmotion);
      
        if (AdamEmotion == "Angry")
        {
            adamAnimator.Play("Punch Combo");
        }

        if (AdamEmotion == "Happy")
        {
            adamAnimator.Play("Cheering");
        }

        if (AdamEmotion == "Annoyed")
        {
            adamAnimator.Play("Shake Fist");
        }

        if (AdamEmotion == "Lonely")
        {
            adamAnimator.Play("Angry Gesture");
        }
    }
   
}
