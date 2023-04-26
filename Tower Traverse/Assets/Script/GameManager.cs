using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region singleton
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        // If there is a pre-existing instance, delete self
        if (Instance != null && Instance != this) Destroy(this);
        else Instance = this;
    }
    #endregion singleton

    public float time = 0;

    void Update()
    {
        time += Time.deltaTime;

        if (time > 10) time = 0;
    }
}
