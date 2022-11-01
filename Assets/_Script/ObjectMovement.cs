using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{

    [Range (0f, 10f)]
    public float speed;

    public GameObject player;

    Rigidbody2D rb;
    Rigidbody2D playerRb;

    bool isGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerRb = player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
      if(isGround == true) 
        {
            Movement();

            if (isGameOver() == true)
            {
                playerRb.velocity = Vector3.right * speed;

                rb.velocity = Vector3.zero;

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    bool isGameOver()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed -= speed * 0.01f;       
            return true;
        }
        else
        {
            return false;
        }
    }

    void Movement()
    {
        rb.velocity = Vector3.right * speed;
        playerRb.velocity = rb.velocity;
    }


}
