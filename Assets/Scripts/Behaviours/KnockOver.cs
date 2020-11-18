using UnityEngine;
using UnityEngine.Events;

public class KnockOver : MonoBehaviour
{
    public bool canKnockOver;
    public float knockedOver;
    public Transform obj;
    public UnityEvent spillEvent;

    private void Start()
    {
        canKnockOver = false;
        knockedOver = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canKnockOver = true;
        }
    }

    private void Update()
    {
        if (!canKnockOver || !(knockedOver >= 1) || !Input.GetKeyDown(KeyCode.C)) return;
        obj.DetachChildren();
        obj.transform.Rotate(90, 0, 0);
        spillEvent.Invoke();
        knockedOver = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        canKnockOver = false;
    }
}