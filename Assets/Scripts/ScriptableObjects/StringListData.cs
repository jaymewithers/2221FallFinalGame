using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class StringListData : ScriptableObject
{
    public List<string> stringList;

    private string returnValue;

    private int i;

    public void GetNextString()
    {
        returnValue = stringList[i];
        i = (i + 1) % stringList.Count;
    }

    public void SetTextUIToValue(Text obj)
    {
        obj.text = returnValue;
    }
}