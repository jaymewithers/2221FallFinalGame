using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PushPull : MonoBehaviour
{
    private Rigidbody rBody;
    public bool canPickup;
    public Transform player;
    public FloatData moveSpeed;
    public IntData isPushing;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
        canPickup = false;
    }

    private void Update()
    {
        if (canPickup && Input.GetKeyDown(KeyCode.Z))
        {
            isPushing.value = 1;
            moveSpeed.value = 3;
            var transformObj = transform;
            transformObj.parent = player;
            canPickup = false;
        }

        if (!Input.GetKeyUp(KeyCode.Z)) return;
        {
            isPushing.value = 0;
            moveSpeed.value = 5;
            var transformObj = transform;
            transformObj.parent = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canPickup = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canPickup = false;
    }
}