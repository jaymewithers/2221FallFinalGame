using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rbody;
    public float force = 500f;

    private void Start()
    {
        rbody = GetComponent<Rigidbody>();
        var forceDirection = new Vector3(force, 0, 0);
        rbody.AddRelativeForce(forceDirection);
    }
}