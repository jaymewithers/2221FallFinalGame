using UnityEngine;
using UnityEngine.Events;

public class CheckOffDisplay : MonoBehaviour
{
    public StringListData value;
    public UnityEvent activate, deactivate;
    public string item;

    private void Update()
    {
        if (value.stringList.Contains(item))
        {
            activate.Invoke();
        }

        if (value.stringList.Remove(item))
        {
            deactivate.Invoke();
        }
    }
}