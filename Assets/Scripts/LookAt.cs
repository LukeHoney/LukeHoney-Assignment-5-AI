using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code to make object look at the target 
public class LookAt : MonoBehaviour
{
    [SerializeField] private Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }
}
