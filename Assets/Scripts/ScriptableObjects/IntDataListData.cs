using System.Collections.Generic;
using UnityEngine;

public class IntDataListData : MonoBehaviour
{
    public List<IntData> intDataList;

    public void AddToList(IntData intValue)
    {
        intDataList.Add(intValue);
    }

    public void SortList()
    {
        intDataList.Sort();
    }
}