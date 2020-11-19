using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ApplyForceToDestination : MonoBehaviour
{
    private Rigidbody rBody;
    public Vector3Data destination;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
        rBody.AddRelativeForce(destination.value);
    }
}