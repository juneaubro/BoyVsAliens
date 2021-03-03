using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BlakAlienAI : MonoBehaviour
{
    [SerializeField] private float detectionRadius;
    [SerializeField] private float maxDistance;
    [SerializeField] private LayerMask player;

    private Transform playerPos;
    private Ray alienRay;
    private RaycastHit rayHit;
    public bool hit;

    private NavMeshAgent agent;
 
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
      
    }

    private void Update()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;

        //if (hit)
        //{
        //    agent.SetDestination(playerPos);
        //}
    }

    //private void OnDrawGizmos()
    //{
    //    hit = Physics.BoxCast(transform.position,transform.lossyScale,transform.forward,out rayHit, transform.rotation, maxDistance, player);

    //    if (hit)
    //    {
    //        Gizmos.color = Color.red;
    //        Gizmos.DrawRay(transform.position, transform.forward * rayHit.distance);
    //        Gizmos.DrawCube(transform.position + transform.forward * rayHit.distance, transform.lossyScale);
    //        transform.LookAt(playerPos);
    //        agent.SetDestination(playerPos.position);
    //    }
    //    else
    //    {
    //        Gizmos.color = Color.green;
    //        Gizmos.DrawRay(transform.position, transform.forward * maxDistance);
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            agent.SetDestination(other.gameObject.transform.position);

        }

    }
}
