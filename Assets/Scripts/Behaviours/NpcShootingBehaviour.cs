using System.Collections;
using UnityEngine;

public class NpcShootingBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public Transform instancer;
    public float holdTime;
    private bool canInstance;
    private WaitForSeconds wfs;

    private void Start()
    {
        wfs = new WaitForSeconds(holdTime);
    }

    public void CallInstance()
    {
        canInstance = true;
        StartCoroutine(Instance());
    }

    private IEnumerator Instance()
    {
        while (canInstance)
        {
            Instantiate(prefab, instancer.position, instancer.rotation);
            yield return wfs;
        }
    }
}