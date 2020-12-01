using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    private Animator myAnimator;

    private Rigidbody myRigidbody;      

    public Transform target;

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();

        myRigidbody = GetComponent<Rigidbody>();

        agent = GetComponent<NavMeshAgent>();

        target = GameObject.Find("Rin").transform;
                
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
    }
}
