using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WalkingGaurdAnimation : MonoBehaviour
{
    public Animator walkingGaurdAnimator;
    public InMemoryVariableStorage yarnInMemoryStorage;

    //Changes WalkingGaurd's animation depending on yarn values

    [YarnCommand("walkingGaurd_animation_selector")]
    public void WalkingGaurdAnimationSelector()
    {
        string walkingGaurdAnimation;
        yarnInMemoryStorage.TryGetValue("$walkingGaurdAnimation", out walkingGaurdAnimation);

        if (walkingGaurdAnimation == "Angry")
        {
            walkingGaurdAnimator.Play("Hook Punch");
        }
    }
}
