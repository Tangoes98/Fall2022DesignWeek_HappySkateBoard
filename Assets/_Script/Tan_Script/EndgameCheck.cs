using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndgameCheck : MonoBehaviour
{
    public GameObject gameOverScreen;

    // if is on ground check
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            gameOverScreen.SetActive(true);
        }
    }

}
