using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    float timePassed;

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > 4) SceneManager.LoadScene("Level1");
    }
}
