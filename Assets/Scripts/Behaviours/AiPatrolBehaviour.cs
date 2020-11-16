using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiPatrolBehaviour : MonoBehaviour
{
    private readonly WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private NavMeshAgent agent;
    public List<Transform> patrolPoints;
    private bool canPatrol;
    private int i;

    private void Start()
    {
        i = 0;
        agent = GetComponent<NavMeshAgent>();
    }

    public void PatrolStart()
    {
        StartCoroutine(Patrol());
    }

    private IEnumerator Patrol()
    {
        canPatrol = true;
        while (canPatrol)
        {
            yield return wffu;
            if (agent.pathPending || !(agent.remainingDistance < 0.5f)) continue;
            agent.destination = patrolPoints[i].position;
            i = (i + 1) % patrolPoints.Count;
        }
    }

    public void ResetPosition(Transform other)
    {
        canPatrol = false;
        StopCoroutine(Patrol());
        agent.destination = other.position;
    }

    public void StopAgent(Transform other)
    {
        canPatrol = false;
        agent.destination = other.position;
    }
}