using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndgameCheck : MonoBehaviour
{
    public GameObject GameOverScreen;
    // if is on ground check
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            Time.timeScale=0f;
            GameOverScreen.SetActive(true);
        }
    }

}
  