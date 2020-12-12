using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiBehaviour : MonoBehaviour
{
    private readonly WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private NavMeshAgent agent;
    private bool canHunt, canPatrol;
    private int i;
    
    public Transform destination;
    public IntData coverData;
    public List<Transform> patrolPoints;
    

    private void Start()
    {
        i = 0;
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Patrol());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        canHunt = true;
        canPatrol = false;  
        StartCoroutine(Hunt());
    }

    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
        canPatrol = true;
        StopCoroutine(Hunt());
        StartCoroutine(Patrol());
    }

    private IEnumerator Hunt()
    {
        canHunt = true;
        while (canHunt && coverData.value == 0)
        {
            yield return wffu;
            agent.destination = destination.position;
        }

        if (coverData.value != 1) yield break;
        canHunt = false;
        canPatrol = true;
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

    public void StopAgent(Transform other)
    {
        canPatrol = false;
        canHunt = false;
        agent.destination = other.position;
    }

    public void StopPatrolAtPosition(Transform other)
    {
        canPatrol = false;
        StopCoroutine(Patrol());
        canHunt = false;
        StopCoroutine(Hunt());
        agent.transform.position = other.position;
    }
}