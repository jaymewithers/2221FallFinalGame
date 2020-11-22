using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameOverCheck : MonoBehaviour
{
    public IntData mainTimer;
    public FloatData health;
    public UnityEvent timeOutEvent;
    public WaitForSeconds wfs = new WaitForSeconds(0.5f);
    

    private void Update()
    {
        if (mainTimer.value <= 0 || health.value <= 0)
        {
            StartCoroutine(GameOver());
        }
    }

    private IEnumerator GameOver()
    {
        yield return wfs;
        timeOutEvent.Invoke();
        Time.timeScale = 0;
    }
}