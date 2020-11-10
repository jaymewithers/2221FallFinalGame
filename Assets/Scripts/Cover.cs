using UnityEngine;
using UnityEngine.Events;

public class Cover : MonoBehaviour
{
    public bool canUse;
    public FloatData coverData;
    public Transform player;
    public Vector3 offset, restOffset;
    public UnityEvent disableEvent, enableEvent;
    
    private void Start()
    {
        coverData.value = 0f;
        canUse = false;
    }
    
    private void Update()
    {
        if (canUse && Input.GetKeyDown(KeyCode.X))
        {
            coverData.value = 1f;
            disableEvent.Invoke();
            var transform1 = transform;
            transform1.position = player.position + offset;
            transform1.parent = player;
            canUse = false;
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            coverData.value = 0f;
            var transform1 = transform;
            transform1.parent = null;
            transform1.position = player.position + restOffset;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canUse = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enableEvent.Invoke();
            canUse = false;
        }
    }
}