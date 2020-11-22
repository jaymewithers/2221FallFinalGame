using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class EndingCheck : MonoBehaviour
{
    public IntData goalValue;
    public UnityEvent endCheckEvent, loseEvent, winEvent;
    public float holdTime;
    private WaitForSeconds wfs;

    private void Start()
    {
        wfs = new WaitForSeconds(holdTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(EndCheckAnticipation());
    }

    private IEnumerator EndCheckAnticipation()
    {
        Time.timeScale = 0;
        endCheckEvent.Invoke();
        yield return wfs;
        EndCheck();
    }

    private void EndCheck()
    {
        switch (goalValue.value)
        {
            case 0:
                print("you lose");
                loseEvent.Invoke();
                break;
            case 20:
                winEvent.Invoke();
                break;
        }
    }
}