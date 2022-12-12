using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class MoveInToBar : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject vrRig;

    public InMemoryVariableStorage yarnInMemoryStorage;

    //If enrty is paid to the security, player is teleported inside pub

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
