using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiHuntBehaviour : MonoBehaviour
{
    private readonly WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private NavMeshAgent agent;
    public Transform destination;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public IEnumerator Hunt()
    {
        yield return wffu;
        agent.destination = destination.position;
    }
}