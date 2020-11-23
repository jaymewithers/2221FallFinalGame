using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EndingCheck : MonoBehaviour
{
    public IntData goalValue;
    public UnityEvent endCheckEvent;
    public float holdTime;
    public GameObject winObj, loseObj;
    private WaitForSeconds wfs;

    private void Start()
    {
        wfs = new WaitForSeconds(holdTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        endCheckEvent.Invoke();
        StartCoroutine(endCheck());
    }

    private IEnumerator endCheck()
    {
        if (goalValue.value == 0)
        {
            yield return wfs;
            loseObj.SetActive(true);
        }

        if (goalValue.value == 18)
        {
            yield return wfs;
            winObj.SetActive(true);
        }
    }
}