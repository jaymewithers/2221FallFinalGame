using UnityEngine;

public class CamBehaviour : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}