using System.Collections;
using UnityEngine;

public class DeathBehaviour : MonoBehaviour
{
    public GameObject gameObj;
    public FloatData health;
    public Vector3Data spawnPoint;

    private void Update()
    {
        if (!(health.value <= 0)) return;
        gameObj.SetActive(false);
        StartCoroutine(Respawn());
    }

    private IEnumerator Respawn()
    {
        if (gameObj.name != "Player") yield break;
        yield return new WaitForSeconds(3f);
        gameObj.transform.position = spawnPoint.value;
        health.value = 1f;
        gameObj.SetActive(true);
        StopCoroutine(Respawn());
    }
}