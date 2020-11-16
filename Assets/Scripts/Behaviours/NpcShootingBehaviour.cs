using System.Collections;
using UnityEngine;

public class NpcShootingBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public Transform instancer;
    private WaitForSeconds wfs;
    public float holdTime = 0.1f;

    private void Start()
    {
        wfs = new WaitForSeconds(holdTime);
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        yield return wfs;
        Instantiate(prefab, instancer.position, instancer.rotation);
    }

    private void OnTriggerExit(Collider other)
    {
        StopCoroutine(OnTriggerEnter(other));
    }
}