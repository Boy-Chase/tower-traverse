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
    private Rigidbody2D rb;
    [SerializeField] private Camera cam; // the camera that follows the player
    [SerializeField] private float mSpeed; // movement speed

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        GetInputs();
    }

    void GetInputs()
    {
        Vector2 movement = Vector2.zero;
        if (Input.GetKey(KeyCode.LeftArrow)) movement.x -= 1;
        if (Input.GetKey(KeyCode.RightArrow)) movement.x += 1;
        if (Input.GetKey(KeyCode.UpArrow)) movement.y += 1;
        if (Input.GetKey(KeyCode.DownArrow)) movement.y -= 1;
        
        rb.velocity = (rb.velocity / 1.5f) + (movement * mSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Key")
        {
            hasKey = true;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Door" && hasKey)
        {
            if(SceneManager.GetActiveScene().name=="Level1") SceneManager.LoadScene("Level2");
            else SceneManager.LoadScene("Win");
        }

        if (other.gameObject.tag == "Arrow" || other.gameObject.tag == "Spikes")
        {
            GameManager.Instance.currentLevel = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("Death");
        }
    }
}
