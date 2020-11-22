using UnityEngine;
using UnityEngine.Events;

public class MaxDeathEvent : MonoBehaviour
{
    public FloatData health;
    public UnityEvent deathEvent;

    public void MaxDeath()
    {
        if (health.value <= 0)
        {
            deathEvent.Invoke();
        }
    }
}