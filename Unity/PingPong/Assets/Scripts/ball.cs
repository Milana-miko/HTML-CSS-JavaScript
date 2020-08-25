using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    public int coeffSpeed;
    public Vector2 direction;
    public int points;
    public player PL;


    void Start()
    {
        speed = 1;
        coeffSpeed = 2;
        direction = new Vector2 (Random.Range(0.5f, 1), Random.Range(0.5f, -1));
        points = 0;
        transform.position = Vector2.zero;
    }

    
    void Update()
    {
        rb.velocity = direction * speed;
        if (transform.position.x > PL.transform.position.x + 1)
        {
            Debug.Log("Game Over!");
            Start();
        
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            direction.x = -direction.x;
            speed = speed * coeffSpeed;
            points = points + 1;
            Debug.Log( points);
        
        }

        if (col.gameObject.CompareTag("TopWall"))
        {
            direction.y = -direction.y;

        }

        if (col.gameObject.CompareTag("BottomWall"))
        {
            direction.y = -direction.y;

        }

        if (col.gameObject.CompareTag("SideWall"))
        {
            direction.x = -direction.x;

        }
    }
}
