using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    private bool hasKey = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("h");

        if (other.gameObject.tag == "Key")
        {
            hasKey = true;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Door" && hasKey)
        {
            Destroy(other.gameObject);
        }
    }
}
