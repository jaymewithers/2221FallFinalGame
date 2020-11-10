using UnityEngine;

public class KnockOver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            other.transform.Rotate(0, 0, 90);
        }
    }
}