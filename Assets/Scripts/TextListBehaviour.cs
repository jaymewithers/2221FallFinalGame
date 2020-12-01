using System;
using UnityEngine;
using UnityEngine.UI;

public class TextListBehaviour : MonoBehaviour
{
    private Text textObj;
    public IntListData intList;
    public StringListData stringList;

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
        
    }
    
    
}