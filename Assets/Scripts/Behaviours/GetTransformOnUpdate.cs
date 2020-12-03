using UnityEngine;

public class GetTransformOnUpdate : MonoBehaviour
{
    public Transform transformObj;
    public Vector3Data transformData;

    private void Update()
    {
        transformData.value = transformObj.position;
    }
}