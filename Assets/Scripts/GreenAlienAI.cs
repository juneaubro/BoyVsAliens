using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GreenAlienAI : MonoBehaviour
{
    [SerializeField] private float detectionLength;

    public bool follow;

    private Ray alienRay;
    private RaycastHit rayHit;

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();    
    }

    private void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            agent.SetDestination(other.gameObject.transform.position);
        }
    }
}
