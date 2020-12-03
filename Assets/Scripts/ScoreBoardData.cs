using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardData : MonoBehaviour
{
    private Text textObj;
    public IntListData intList;
    public StringListData stringList;

    public StringData stringObj;
    public IntData intObj;

    private void Start()
    {
        textObj = GetComponent<Text>();
    }

    public void UpdateList()
    {
        textObj.text = stringObj.value + intObj.value;
    }
}