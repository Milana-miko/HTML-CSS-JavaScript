using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;

    void Start()
    {
        speed = 4;
    }

   
    void Update()
    {
        Vector2 direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up * speed;
            
            // rb.velocity = Vector2.up * speed;   
           //rb.velocity = new Vector2(0, 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down * speed;

            //rb.velocity = Vector2.down * speed;     
            //rb.velocity = new Vector2(0, -1);
        }

        rb.velocity = direction * speed;

    }
}
