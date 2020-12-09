using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterBehaviour : MonoBehaviour
{
    public IntData playerJumpCount, isPushing;
    public FloatData normalSpeed, fastSpeed, energy;
    public float rotateSpeed = 120f, gravity = -9.81f, jumpForce = 5f, energyChange = 0.1f;
    public bool canRun = true;
    public WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    public float delayTime = 0.5f;

    protected CharacterController controller;
    protected Vector3 movement;

    private WaitForSeconds wfs;
    private float yVar;
    private int jumpCount;
    private FloatData moveSpeed;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        moveSpeed = normalSpeed;
        wfs = new WaitForSeconds(delayTime);
        isPushing.value = 0;
    }

    public void Update()
    {
        if (energy.value < 0)
        {
            canRun = false;
            moveSpeed = normalSpeed;
        }
        else
        {
            canRun = true;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftShift) && canRun && isPushing.value == 0)
        {
            moveSpeed = fastSpeed;
            StopCoroutine(EnergyReFill());
            StartCoroutine(EnergyDrain());
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = normalSpeed;
            StopCoroutine(EnergyDrain());
            StartCoroutine(EnergyReFill());
        }

        var vInput = Input.GetAxis("Vertical") * moveSpeed.value;
        movement.Set(vInput, yVar, 0);

        var hInput = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0, hInput, 0);

        yVar += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < playerJumpCount.value)
        {
            yVar = jumpForce;
            jumpCount++;
        }

        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
    
    private IEnumerator EnergyDrain()
    {
        while (moveSpeed == fastSpeed && energy.value > 0)
        {
            yield return wffu;
            energy.value -= energyChange;
            yield return wfs;
        }
    }

    private IEnumerator EnergyReFill()
    {
        while (moveSpeed == normalSpeed && energy.value < 1)
        {
            yield return wffu;
            energy.value += energyChange;
            yield return wfs;
        }
    }
}