using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateboardSpeed : MonoBehaviour
{
     // NOTE: Keys do not allow you to press multiple inputs at once. If you do, it will detect a key press when not intended. Don't know if this will be an issue with the controller.

    // NOTE 2: Issue with attempting to flick from half swipe (ex. a+s) to swipe in opposite direction (ex. a+s -> d+s). As of now, you have to complete full swipe to switch direction.

    Rigidbody2D rigidbody_skateboard;

    public float speed;

    private bool keyAPressedBefore = false, keySPressedBefore = false, keyDPressedBefore = false;   // Used when detecting the sequence of button presses.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
                            speed += 0.5f;   // Small increase in speed.
                            rigidbody_skateboard.velocity = new Vector2(speed, 0);
                            keySPressedBefore = true;
                        }
                        else
                        {
                            if (Input.GetKey("d"))
                            {
                                speed += 0.5f; // Small increase in speed, would stack with previous increase.
                                rigidbody_skateboard.velocity = new Vector2(speed, 0);
                                keyAPressedBefore = false;
                                keySPressedBefore = false;
                                keyDPressedBefore = false;
                            }
                            else
                            {
                                keyAPressedBefore = false;
                                keySPressedBefore = false;
                                keyDPressedBefore = false;
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
            /*else
            {
                keyAPressedBefore = false;
            }*/
            
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
                            speed -= 0.5f;   // Small increase in speed towards the left.
                            rigidbody_skateboard.velocity = new Vector2(speed, 0);
                            keySPressedBefore = true;
                        }
                        else
                        {
                            if (Input.GetKey("a"))
                            {
                                speed -= 0.5f; // Small increase in speed towards the left, would stack with previous increase.
                                rigidbody_skateboard.velocity = new Vector2(speed, 0);
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
    }
}
