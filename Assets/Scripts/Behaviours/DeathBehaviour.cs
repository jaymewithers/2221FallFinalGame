﻿using System.Collections;
using UnityEngine;

public class DeathBehaviour : MonoBehaviour
{
    public GameObject gameObj;
    public FloatData health, playerLives;
    public Vector3Data spawnPoint;

    private void Update()
    {
        if (!(health.value <= 0)) return;
        gameObj.SetActive(false);
        StartCoroutine(Respawn());

        if (!(playerLives.value <= 0)) return;
        gameObj.SetActive(false);
        print("Game Over");
    }

    private IEnumerator Respawn()
    {
        if (gameObj.name != "Player" && playerLives.value > 0) yield break;
        {
            yield return new WaitForSeconds(3f);
            gameObj.transform.position = spawnPoint.value;
            health.value = 1f;
            gameObj.SetActive(true);
            StopCoroutine(Respawn());
        }
    }
}