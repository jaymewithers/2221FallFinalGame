using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class EventCoroutine : MonoBehaviour
{
   public UnityEvent startEvent, middleEvent, secondMiddleEvent, endEvent;
   public float holdTime;
   private WaitForSeconds wfs;

   private void Start()
   {
      wfs = new WaitForSeconds(holdTime);
   }

   public void Run()
   {
      StartCoroutine(OnRun());
   }

   private IEnumerator OnRun()
   {
      startEvent.Invoke();
      yield return wfs;
      middleEvent.Invoke();
      yield return wfs;
      secondMiddleEvent.Invoke();
      yield return wfs;
      endEvent.Invoke();
   }
}