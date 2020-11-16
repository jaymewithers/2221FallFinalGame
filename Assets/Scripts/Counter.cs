using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    public IntData timer;
    public WaitForSeconds wfs;
    public float holdTime;
    public UnityEvent timeOutEvent;

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
        while (timer.value >= 0.5)
        {
            yield return wfs;
            timer.value--;
        }

        if (timer.value <= 0)
        {
            timeOutEvent.Invoke();
        }
    }
}