using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMove : MonoBehaviour
{
    Animator animator;
    [SerializeField] Transform target;
    [SerializeField] NavMeshAgent agent;

    public int state;

    bool detected;
    Transform goal;

    [SerializeField] Transform player;

    float visionRange = 40f;

    void Start()
    {
        animator = GetComponent<Animator>();
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("State", state);
        if (state == 2)
        {
            agent.SetDestination(target.position);
        }
        DetectarJugador();
        CambiarEstado();
        SetSpeed();
    }

    void CambiarEstado()
    {
        if ((state == 0 || state == 1) && (detected == true))
        {
            state = 2;
            animator.SetFloat("State", state);
        }

        if (detected == false)
        {
            state = 0;
            animator.SetFloat("State", state);
        }
    }

    void DetectarJugador()
    {
        float distance;

        distance = Vector3.Distance(transform.position, player.position);

        if (distance < visionRange)
        {
            detected = true;
        }
        else
        {
            detected = false;
        }
    }

    void SetSpeed()
    {
        if (state == 0)
        {
            agent.speed = 0f;
        }
        else
        {
            agent.speed = 4f;
        }
    }
}