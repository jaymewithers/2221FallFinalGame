using System.Collections;
using UnityEngine;

public class TurretBehaviour : MonoBehaviour
{
    public Vector3Data obj;
    public IntData coverData;
   
    private IEnumerator OnTriggerEnter(Collider other)
    {
        while (coverData.value == 0)
        {
            yield return new WaitForFixedUpdate();
            Transform transform1;
            (transform1 = transform).LookAt(obj.value); 
            var transformRotation = transform1.eulerAngles;
            transformRotation.x = 0;
            transformRotation.y -= 90;
            transform.rotation = Quaternion.Euler(transformRotation);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        StopAllCoroutines();
    }
}