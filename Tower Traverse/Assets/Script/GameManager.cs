using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region singleton
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        // If there is a pre-existing instance, delete self
        if (Instance != null && Instance != this) Destroy(this);
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    #endregion singleton

    public string currentLevel;

    void Update()
    {
        if (Input.GetKey(KeyCode.R)) SceneManager.LoadScene("StartScene");
    }
}
