using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MaynardAnimations : MonoBehaviour
{
    [Header("Animation Controls")]
    [SerializeField] private float walkSpeedTransformation;

    private float speed;
    private bool attack;

    NavMeshAgent agent;
    Animator anim;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        
    }
    private void Update()
    {
        speed = Mathf.Abs(agent.velocity.x + agent.velocity.z);

        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("melee"))
        {
            anim.SetFloat("speed", speed);
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("melee"))
        {
            agent.velocity = Vector3.zero;
        }
    }

    IEnumerator Hit()
    {
        if (attack == true)
        {
            anim.SetTrigger("hit");

            yield return new WaitForSeconds(1);

            PlayerHealth.currentHealth -= 40;

            attack = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            attack = true;
            StartCoroutine(Hit());
        }
    }
}
