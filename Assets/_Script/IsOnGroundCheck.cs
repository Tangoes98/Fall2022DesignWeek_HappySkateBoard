using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOnGroundCheck : MonoBehaviour
{
    public bool isGround;

    private void Awake()
    {
        isGround = false;
    }

    // if is on ground check
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
