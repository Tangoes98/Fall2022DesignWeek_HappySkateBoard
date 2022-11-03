using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpeed : MonoBehaviour
{
    // NOTE: Keys do not allow you to press multiple inputs at once. If you do, it will detect a key press when not intended. Don't know if this will be an issue with the controller.

    // NOTE 2: Issue with attempting to flick from half swipe (ex. a+s) to swipe in opposite direction (ex. a+s -> d+s). As of now, you have to complete full swipe to switch direction.

    [SerializeField]
    GameObject Player;
    Rigidbody2D rb;


    [Range(0f, 5000f)]
    public float deltaV;

    public float chargeSpeed;
    public float speed;


    //private bool keyAPressedBefore = false, keySPressedBefore = false, keyDPressedBefore = false;   // Used when detecting the sequence of button presses.


    public void Awake()
    {
        rb = Player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        NewTwoKeyMovement();
    }


    void NewTwoKeyMovement()
    {
        if (Player.GetComponent<IsOnGroundCheck>().isGround == true)
        {
            var canJump = true;
            //speed function
            if (Input.GetKey(KeyCode.D))
            {
                chargeSpeed += deltaV;
                chargeSpeed = Mathf.Clamp(chargeSpeed, deltaV, deltaV * 150);
                canJump = false;
                if (Input.GetKeyDown(KeyCode.S))
                {
                    speed += chargeSpeed;
                    rb.velocity = Vector3.right * speed * Time.deltaTime;
                    chargeSpeed = 0f;
                    speed = 0f;
                }
            }
            else if (Input.GetKey(KeyCode.A))
            {
                canJump = false;
                if (Input.GetKeyDown(KeyCode.S))
                {
                    Debug.Log("Back");
                    speed -= deltaV * 100;
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
            if (Input.GetKeyDown(KeyCode.S) && canJump == true)
            {
                rb.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
            }
        }
    }


    /*    void TwoKeyMovement()
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

    /*
        void OldMovement()
        {
            // Moving Forwards:

            if (Input.anyKeyDown)
            {
                if ((Input.GetKey("a") || keyAPressedBefore) && keyDPressedBefore == false)
                {
                    if (Input.GetKey("a"))

                        keyAPressedBefore = true;

                    else
                    {
                        if (Input.GetKey("s") || keySPressedBefore)
                        {
                            if (Input.GetKey("s"))
                            {
                                speed += deltaV;   // Small increase in speed.
                                rb.velocity = Vector3.right * speed * Time.deltaTime;
                                keySPressedBefore = true;
                            }
                            else
                            {
                                if (Input.GetKey("d"))
                                {
                                    speed += deltaV; // Small increase in speed, would stack with previous increase.
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
                        else if (Input.GetKey("a"))     //Triggers if the user hits a after already pressing a+s. This prevents issues when trying to string a+s to a+s.
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
            }


            // Moving Backwards:
            else if (Input.GetKey("d") || keyDPressedBefore)
            {
                if (Input.GetKey("d"))
                    keyDPressedBefore = true;
                else
                {
                    if (Input.GetKey("s") || keySPressedBefore)
                    {
                        if (Input.GetKey("s"))
                        {
                            speed -= deltaV;   // Small increase in speed towards the left.
                            rb.velocity = Vector3.right * speed * Time.deltaTime;
                            keySPressedBefore = true;
                        }
                        else
                        {
                            if (Input.GetKey("a"))
                            {
                                speed -= deltaV; // Small increase in speed towards the left, would stack with previous increase.
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
                    else if (Input.GetKey("d"))     //Triggers if the user hits d after already pressing d+s. This prevents issues when trying to string d+s to d+s.
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
            }
            else
            {
                keyDPressedBefore = false;
                keyAPressedBefore = false;
                keySPressedBefore = false;
            }
        }
    */

}




