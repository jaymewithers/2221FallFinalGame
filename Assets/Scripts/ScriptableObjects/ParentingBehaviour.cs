using UnityEngine;

public class ParentingBehaviour : MonoBehaviour
{
    public void DetachChild(GameObject obj)
    {
        obj.transform.parent = null;
    }
}