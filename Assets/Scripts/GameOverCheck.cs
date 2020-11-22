using UnityEngine;
using UnityEngine.Events;

public class GameOverCheck : MonoBehaviour
{
    public IntData mainTimer;
    public FloatData health;
    public UnityEvent timeOutEvent;

    private void Update()
    {
        if (mainTimer.value <= 0 || health.value <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        timeOutEvent.Invoke();
        Time.timeScale = 0;
    }
}