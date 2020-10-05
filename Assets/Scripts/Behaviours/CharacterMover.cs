using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;

    public float gravity = -9.81f;
    private float yVar;

    public FloatData normalSpeed, fastSpeed;
    private FloatData moveSpeed;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        moveSpeed = normalSpeed;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = fastSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = normalSpeed;
        }
        
        var vInput = Input.GetAxis("Vertical") * moveSpeed.value;

        var hInput = Input.GetAxis("Horizontal") * moveSpeed.value;
        movement.Set(hInput, yVar, vInput);

        yVar += gravity * Time.deltaTime;
        
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}