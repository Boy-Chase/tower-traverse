using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerShooter : MonoBehaviour
{
    public Vector2 tilePos = new Vector2(0,0);
    public float timer = 0.0f;
    public GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (3 < timer)
        {
            Instantiate(arrow);
            arrow.transform.position = tilePos;
            timer = 0.0f;
        }
    }
}
