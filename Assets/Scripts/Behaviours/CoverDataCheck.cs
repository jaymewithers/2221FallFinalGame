using UnityEngine;
using UnityEngine.Events;

public class CoverDataCheck : MonoBehaviour
{
    public IntData coverData;
    public UnityEvent zeroEvent, oneEvent;

    private void Update()
    {
        switch (coverData.value)
        {
            case 1:
                oneEvent.Invoke();
                break;
            case 0:
                zeroEvent.Invoke();
                break;
        }
    }
}