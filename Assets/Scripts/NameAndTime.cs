using System.Collections.Generic;
using UnityEngine;

public class NameAndTime : MonoBehaviour
{
  public int intValue;
  public string stringValue;

  public NameAndTime(int intObj, string stringObj)
  {
      intValue = intObj;
      stringValue = stringObj;
  }
  
  public List<NameAndTime> nameAndTime = new List<NameAndTime>();
}