using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    [Range(50f, 100f)]
    public float deltaV;

    public float speed;

    [SerializeField]
    GameObject Player;

    Rigidbody2D rb;


    [Range(5f, 30f)]
    public float deltaRt;
    float rt;

    public GameObject leftPvPos;
    public GameObject rightPvPos;



 
    public void Awake()
    {
        rb = Player.GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
/*
        if (Player.GetComponent<IsOnGroundCheck>().isGround == true
            )
        {
            //input to move the player rb to right
            if (Input.GetKey(KeyCode.D))
            {
                speed += deltaV * 0.1f;
                rb.velocity = Vector3.right * speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                speed += deltaV * 0.1f;
                rb.velocity = Vector3.left * speed * Time.deltaTime;
            }
            else
            {
                speed = 0f;
            }

            //test jump
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //rb.velocity = Vector3.up * 20f * Time.deltaTime;
                rb.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
            }

        }
*/

        if (Input.GetKey(KeyCode.Space))
        {
            rt += deltaRt * 0.5f * Time.deltaTime;
            //Player.transform.Rotate(Vector3.forward, rt, Space.Self); //this will rotate around itself
            Player.transform.RotateAround(leftPvPos.transform.position, leftPvPos.transform.forward, rt);
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {

            rt += deltaRt * 0.5f * Time.deltaTime;
            //Player.transform.Rotate(Vector3.back, rt, Space.Self);
            Player.transform.RotateAround(rightPvPos.transform.position, -rightPvPos.transform.forward, rt);
        }
        else
        {
            rt = 0;
        }




    }

    








}
