using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] private Transform player; //refernce to what chicken has to look at (Bread)


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player); //code to make object look at the target 
        
    }

}
