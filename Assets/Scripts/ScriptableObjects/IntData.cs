using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public void SetValue(int number)
    {
        value = number;
    }

    public void UpdateValue(int number)
    {
        value += number;
    }

    public void CheckForUnder()
    {
        if (value <= 0)
        {
            value = 0;
        }
    }
}