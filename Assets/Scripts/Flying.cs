using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    //public Transform vrRig;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 1, 0) * Time.deltaTime;
    }
}
