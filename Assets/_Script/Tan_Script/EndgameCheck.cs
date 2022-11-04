using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndgameCheck : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject victoryScreen;

    // if is on ground check
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
        }
        else if (collision.gameObject.CompareTag("Finish"))
        {
            Time.timeScale = 0f;
            victoryScreen.SetActive(true);
        }
    }

}
