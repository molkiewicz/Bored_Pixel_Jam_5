﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("GameStateManager").GetComponent<GameStateManager>().WinGame();
        }
    }
}
