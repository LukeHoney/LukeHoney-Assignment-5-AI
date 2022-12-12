using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Edited for 
public class NavAgentMove : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Following Cube(Clone)").transform;
        agent.SetDestination(target.position);
    }
}
