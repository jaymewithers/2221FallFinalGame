using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyMover : MonoBehaviour
{
    private Rigidbody rBody;
    private Vector3 movement;
    public float moveSpeed = 10f;

    public float rotateSpeed = 120f;
    private float yVar;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var vInput = Input.GetAxis("Vertical") * moveSpeed;
        movement.Set(vInput, 0, 0);

        var hInput = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0, hInput, 0);

        movement = transform.TransformDirection(movement);
        rBody.MovePosition(movement * Time.deltaTime);
    }
}
