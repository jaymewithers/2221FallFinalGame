using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntListData : ScriptableObject
{
   public List<int> intList;

   public void AddToList(IntData intValue)
   {
      intList.Add(intValue.value);
   }

   public void OrganizeList()
   {
      intList.Sort();
   }
}