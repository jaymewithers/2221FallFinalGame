﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EndingCheck : MonoBehaviour
{
    public IntData goalValue;
    public UnityEvent endCheckEvent;
    public float holdTime;
    public GameObject winObj, loseObj, win2Obj, lose2Obj;
    private WaitForSeconds wfs;

    private void Start()
    {
        wfs = new WaitForSeconds(holdTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        endCheckEvent.Invoke();
        StartCoroutine(endCheck());
    }

    private IEnumerator endCheck()
    {
        if (goalValue.value == 0)
        {
            yield return wfs;
            loseObj.SetActive(true);
            lose2Obj.SetActive(true);
        }

        if (goalValue.value == 18)
        {
            yield return wfs;
            winObj.SetActive(true);
            win2Obj.SetActive(true);
        }
    }
}