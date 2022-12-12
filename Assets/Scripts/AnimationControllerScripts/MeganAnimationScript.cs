using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class MeganAnimationScript : MonoBehaviour
{
    public Animator meganAnimator;

    public InMemoryVariableStorage yarnInMemoryStorage;


    [YarnCommand("megan_animation_selector")]
    public void MeganAnimationSelector()
    {
        string MeganWalk;
        yarnInMemoryStorage.TryGetValue("$meganWalk", out MeganWalk);

        if (MeganWalk == "no")
        {
            
            meganAnimator.Play("Idle");
        }

    }
}
