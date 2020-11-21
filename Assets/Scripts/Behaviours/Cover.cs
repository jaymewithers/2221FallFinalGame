using UnityEngine;
using UnityEngine.Events;

public class Cover : MonoBehaviour
{
    public bool canUse, canLetGo;
    public IntData coverData;
    public Transform player, obj;
    public Vector3 offset, restOffset;
    public UnityEvent disableEvent, enableEvent;
    
    private void Start()
    {
        coverData.value = 0;
        canUse = false;
        canLetGo = false;
    }

    private void Update()
    {
        if (canUse && Input.GetKeyDown(KeyCode.X))
        {
            coverData.value = 1;
            disableEvent.Invoke();
            obj.transform.position = player.position + offset;
            obj.parent = player;
            canLetGo = true;
        }

        if (!Input.GetKeyUp(KeyCode.X) || !canLetGo) return;
        coverData.value = 0;
        obj.parent = null;
        obj.position += restOffset;
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
        enableEvent.Invoke();
        canUse = false;
        canLetGo = false;
    }
}