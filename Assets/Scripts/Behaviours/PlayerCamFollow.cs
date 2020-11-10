using UnityEngine;

public class PlayerCamFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 position;

    private void Update()
    {
        var xInput = player.position.x;
        var zInput = player.position.z;
        position = new Vector3(xInput,4 , zInput);
        transform.position = position;
    }
}