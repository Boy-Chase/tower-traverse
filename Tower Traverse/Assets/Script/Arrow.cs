using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 v = new Vector2(2,0);
    float timer = 0.00f;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = v;

        timer += Time.deltaTime;
        if (10 < timer)
        {
            Destroy(gameObject);
        }
    }
}
