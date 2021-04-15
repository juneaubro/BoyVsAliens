using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class MaynardAI : MonoBehaviour
{
    NavMeshAgent agent;
    public Text killMaynardQuest;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            agent.SetDestination(other.gameObject.transform.position);
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            MaynardHealth.currentHealth -= 23;
            if (MaynardHealth.currentHealth <= 0)
            {
                killMaynardQuest.color = UnityEngine.Color.green;
                Destroy(this.gameObject);
            }
            Destroy(other.gameObject);
        }
    }
}
