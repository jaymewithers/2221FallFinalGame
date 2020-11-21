using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsWithCover : MonoBehaviour
{
   public UnityEvent triggerEnterEvent, triggerExitEvent;
   public float delayTime = 0.01f;
   public IntData coverData;
   private WaitForSeconds waitObj;

   private void Start()
   {
      waitObj = new WaitForSeconds(delayTime);
   }

   private IEnumerator OnTriggerEnter(Collider other)
   {
      while (coverData.value == 0)
      {
         yield return waitObj;
         triggerEnterEvent.Invoke();
      }
   }

   private void OnTriggerExit(Collider other)
   {
      triggerExitEvent.Invoke();
   }
}