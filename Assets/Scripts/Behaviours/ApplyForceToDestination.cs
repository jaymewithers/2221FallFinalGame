using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ApplyForceToDestination : MonoBehaviour
{
    private Rigidbody rBody;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
        var forceDirection = new Vector3(250, 0,0);
        rBody.AddRelativeForce(forceDirection);
    }
}