using UnityEngine;

public class NpcShootingBehaviour : MonoBehaviour
{
   public Transform startPoint, targetPoint;
   public void InstanceAtTransform(GameObject prefab)
   {
      var newInstance = Instantiate(prefab, startPoint.position, Quaternion.identity);
      newInstance.transform.LookAt(targetPoint.position);
   }
}