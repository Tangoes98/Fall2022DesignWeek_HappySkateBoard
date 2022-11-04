using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpeed : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    Rigidbody2D rb;

    //[Range(0f, 5000f)]
    public float deltaV = 20;

    public float chargeSpeed;
    public float speed;


    private bool keyAPressedBefore = false, keySPressedBefore = false, keyDPressedBefore = false;   // Used when detecting the sequence of button presses.


    public void Awake()
    {
        rb = Player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKey("a"))
            {
                if (Player.GetComponent<IsOnGroundCheck>().isGround == true)
                {
                    Jump();
                }
            }
            else
            {
                Movement();
            }
        }

        if(speed>0)
        {
            speed -= 1;
        }
    }


    /*void NewTwoKeyMovement()
    {
        if (Player.GetComponent<IsOnGroundCheck>().isGround == true)
        {
            var canJump = true;
            //speed function
            if (Input.GetKey(KeyCode.RightArrow))
            {
                chargeSpeed += deltaV;
                chargeSpeed = Mathf.Clamp(chargeSpeed, deltaV, deltaV * 150);
                canJump = false;
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    speed += chargeSpeed;
                    rb.velocity = Vector3.right * speed * Time.deltaTime;
                    chargeSpeed = 0f;
                    speed = 0f;
                }
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                canJump = false;
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    //Debug.Log("Back");
                    speed -= deltaV * 50;
                    rb.velocity = Vector3.right * speed * Time.deltaTime;
                    chargeSpeed = 0;
                }
            }
            else
            {
                chargeSpeed = 0;
                speed = 0;
            }

            // jump function
            if (Input.GetKeyDown(KeyCode.UpArrow) && canJump == true)
            {
                rb.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
            }
        }
    }*/


    /*void TwoKeyMovement()
        {
            if (Input.GetKeyUp(KeyCode.A) && Input.GetKey(KeyCode.S))
            {
                speed += deltaV;   // Small increase in speed.
                rb.velocity = Vector3.right * speed * Time.deltaTime;
            }
            else if (Input.GetKeyUp(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                speed -= deltaV;   // Small increase in speed towards the left.
                rb.velocity = Vector3.right * speed * Time.deltaTime;
            }
            else
            {
                speed = 0;
            }
        }
    */

    
    void Movement()
        {
            // Moving Forwards:
            //if (speed<=4000)
            //{
                if ((Input.GetKey("d") || keyAPressedBefore) && keyDPressedBefore == false)
                {
                    if (Input.GetKey("d"))

                        keyAPressedBefore = true;

                    else
                    {
                        if (Input.GetKey("w") || keySPressedBefore)
                        {
                            if (Input.GetKey("w"))
                            {
                                if(speed < 4000)
                                {
                                    speed += deltaV * 30;   // Small increase in speed.
                                }
                                rb.velocity = Vector3.right * speed * Time.deltaTime;
                                keySPressedBefore = true;
                            }
                            else
                            {
                                if (Input.GetKey("s"))
                                {
                                    if(speed < 4000)
                                    {
                                        speed += deltaV * 30; // Small increase in speed, would stack with previous increase.
                                    }
                                    rb.velocity = Vector3.right * speed * Time.deltaTime;
                                    keyAPressedBefore = false;
                                    keySPressedBefore = false;
                                    keyDPressedBefore = false;
                                }
                                else
                                {
                                    keyAPressedBefore = false;
                                    keySPressedBefore = false;
                                    keyDPressedBefore = false;
                                    speed = 0f;
                                }
                            }
                        }
                        else if (Input.GetKey("d"))     //Triggers if the user hits a after already pressing a+s. This prevents issues when trying to string a+s to a+s.
                        {
                            keySPressedBefore = false;
                        }
                        else
                        {
                            keyAPressedBefore = false;
                            keySPressedBefore = false;
                        }
                    }
                }
            //}


            // Moving Backwards:
            /*else if (Input.GetKey("s") || keyDPressedBefore)
            {
                if (Input.GetKey("s"))
                    keyDPressedBefore = true;
                else
                {
                    if (Input.GetKey("w") || keySPressedBefore)
                    {
                        if (Input.GetKey("w"))
                        {
                            if(speed > -4000)
                            {
                                speed -= deltaV * 20;   // Small increase in speed towards the left.
                            }
                            rb.velocity = Vector3.right * speed * Time.deltaTime;
                            keySPressedBefore = true;
                        }
                        else
                        {
                            if (Input.GetKey("d"))
                            {
                                if(speed > -4000)
                                {
                                    speed -= deltaV * 20; // Small increase in speed towards the left, would stack with previous increase.
                                }
                                rb.velocity = Vector3.right * speed * Time.deltaTime;
                                keyAPressedBefore = false;
                                keySPressedBefore = false;
                                keyDPressedBefore = false;
                            }
                            else
                            {
                                keyDPressedBefore = false;
                                keySPressedBefore = false;
                                keyAPressedBefore = false;
                            }
                        }
                    }
                    else if (Input.GetKey("s"))     //Triggers if the user hits d after already pressing d+s. This prevents issues when trying to string d+s to d+s.
                    {
                        keySPressedBefore = false;
                    }
                    else
                    {
                        //keyAPressedBefore = false;
                        keyDPressedBefore = false;
                        keySPressedBefore = false;
                    }
                }
            }*/
            else
            {
                keyDPressedBefore = false;
                keyAPressedBefore = false;
                keySPressedBefore = false;
            }
            Awake();
        }
    void Jump() 
    {
        rb.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
    }
}