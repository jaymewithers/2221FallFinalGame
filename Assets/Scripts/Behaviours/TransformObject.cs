using UnityEngine;

public class TransformObject : MonoBehaviour
{
    public Transform original;
    
    public void TransformObj(Transform obj)
    {
        original.transform.position = obj.position;
    }
}