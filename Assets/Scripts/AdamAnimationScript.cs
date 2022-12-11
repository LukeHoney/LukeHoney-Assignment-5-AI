using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class AdamAnimationScript : MonoBehaviour
{

    public Animator adamAnimator;

    public InMemoryVariableStorage yarnInMemoryStorage;

    // Start is called before the first frame update
    void Start()
    {
        //adamAnimator = GetComponent<Animator>();
    }

    [YarnCommand("adam_animation_selector")]
    public void AdamAnimationSelector()
    {
        string AdamEmotion;
        yarnInMemoryStorage.TryGetValue("$AdamEmotion", out AdamEmotion);
      
        if (AdamEmotion == "Angry")
        {
            adamAnimator.Play("Punch Combo");
            //StartCoroutine(WaitSad());
           
        }

        if (AdamEmotion == "Happy")
        {
            adamAnimator.Play("Cheering");
            
        }

        if (AdamEmotion == "Annoyed")
        {
            adamAnimator.Play("Shake Fist");
            //StartCoroutine(WaitSad());
        }
        if (AdamEmotion == "Lonely")
        {
            adamAnimator.Play("Angry Gesture");
            //StartCoroutine(WaitSad());
        }
    }
    IEnumerator WaitSad()

    {
        yield return new WaitForSeconds(3);
        adamAnimator.Play("Sad Idle");
    }
}
