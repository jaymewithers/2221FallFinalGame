using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextListBehaviour : MonoBehaviour
{
    private Text textObj;
    public IntListData intList;
    public StringListData stringList;
    public NameAndTime listObj;

    private void Start()
    {
        textObj = GetComponent<Text>();
    }

    public void UpdateIntList()
    {
        textObj.text = stringList.stringList.Count.ToString();
    }

    public void UpdateStringList()
    {
        var list = new List<NameAndTime>();
        listObj = list[0];
    }
    
    
}