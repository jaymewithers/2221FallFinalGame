﻿using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void Update() 
    {
        if (Input.GetKey("escape")) 
            Application.Quit();
    }

    public void EndGame()
    {
        Application.Quit();
    }
}