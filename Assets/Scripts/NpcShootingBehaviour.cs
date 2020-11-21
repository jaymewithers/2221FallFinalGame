using System.Collections;
using UnityEngine;

public class NpcShootingBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public Transform instancer;
    public float holdTime;
    private WaitForSeconds wfs;

    private void Start()
    {
        wfs = new WaitForSeconds(holdTime);
    }

    public void CallInstance()
    {
        StartCoroutine(Instance());
    }

    private IEnumerator Instance()
    {
        Instantiate(prefab, instancer.position, instancer.rotation);
        yield return wfs;
    }
}