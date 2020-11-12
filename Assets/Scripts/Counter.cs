using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public IntData timer;
    public WaitForSeconds wfs;
    public float holdTime;

    private void Start()
    {
        wfs = new WaitForSeconds(holdTime);
    }

    public void CountDownTrigger()
    {
        StartCoroutine(CountDown());
    }

    public IEnumerator CountDown()
    {
        while (timer.value >= 0)
        {
            yield return wfs;
            timer.value--;
        }
    }
}