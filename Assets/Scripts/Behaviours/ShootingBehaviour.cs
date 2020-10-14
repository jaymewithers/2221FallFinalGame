using UnityEngine;

public class ShootingBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public Transform instancer;
    public IntData playerAmmo;

    private void Update()
    {
        if (!Input.GetButtonDown("Fire1") || playerAmmo.value <= 0) return;
        Instantiate(prefab, instancer.position, instancer.rotation);
        playerAmmo.value--;
    }
}