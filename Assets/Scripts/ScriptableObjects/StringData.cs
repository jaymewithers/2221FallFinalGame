using UnityEngine;

[CreateAssetMenu]
public class StringData : ScriptableObject
{
   public string value;

   public void ChangeString(StringData other)
   {
      value = other.value;
   }
}