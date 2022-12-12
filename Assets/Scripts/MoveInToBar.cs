using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

//This Script activate whem the user pays enrty to the security to access the pub, player is teleported inside pub
public class MoveInToBar : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject vrRig;

    public InMemoryVariableStorage yarnInMemoryStorage;

    

    [YarnCommand("teleportToBar")]
    public void teleportToBar()
    {
        bool paidEntry;
        yarnInMemoryStorage.TryGetValue("$paidEntry", out paidEntry);

        if (paidEntry==true)
        {
            vrRig.transform.position = teleportTarget.transform.position;
        }
    }
}
