using System.Collections;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class TriggerColorBehaviour : MonoBehaviour
{
    private MeshRenderer meshRObj;
    public Color defaultColor;
    public Color newColor;
    private WaitForSeconds wfs;
    public IntData holdTime;
    public GameObject door;

    private void Start()
    {
        meshRObj = GetComponent<MeshRenderer>();
        defaultColor.a = 1;
        meshRObj.material.color = defaultColor;
        wfs = new WaitForSeconds(holdTime.value);
    }

    private void OnTriggerEnter(Collider other)
    {
        newColor.a = 0.5f;
        meshRObj.material.color = newColor;
        door.SetActive(false);
    }

    private IEnumerator OnTriggerExit(Collider other)
    {
        yield return wfs;
        meshRObj.material.color = defaultColor;
        door.SetActive(true);
    }
}