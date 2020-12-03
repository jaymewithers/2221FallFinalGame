using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameOverCheck : MonoBehaviour
{
    public IntData mainTimer;
    public FloatData health;
    public StringListData list;
    public UnityEvent timeOutEvent, itemsEvent, finishedEvent;
    public WaitForSeconds wfs = new WaitForSeconds(0.5f);
    

    private void Update()
    {
        if (mainTimer.value <= 0 || health.value <= 0)
        {
            StartCoroutine(GameOver());
        }

        switch (list.stringList.Count)
        {
            case 8:
                itemsEvent.Invoke();
                break;
            case 18:
                finishedEvent.Invoke();
                break;
        }
    }

    private IEnumerator GameOver()
    {
        yield return wfs;
        timeOutEvent.Invoke();
        Time.timeScale = 0;
    }
}