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
        endCheckEvent.Invoke();
        
        if (goalValue.value == 0)
        {
            Time.timeScale = 0;
            loseEvent.Invoke();
        }

        if (goalValue.value == 20)
        {
            Time.timeScale = 0;
            winEvent.Invoke();
        }
    }
}