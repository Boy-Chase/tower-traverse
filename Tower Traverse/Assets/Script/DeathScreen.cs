using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    float timePassed;

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > 4) SceneManager.LoadScene(GameManager.Instance.currentLevel);
    }
}