using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierNoise : MonoBehaviour
{
    //plays audio when in contact with player
    public GameObject moveAudio;

    void Start()
    {
        moveAudio.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            moveAudio.SetActive(true);
            StartCoroutine(Wait());

            Debug.Log("hit player");

        }
            
    }
    IEnumerator Wait()

    {
        yield return new WaitForSeconds(2);
        moveAudio.SetActive(false);
    }
}
