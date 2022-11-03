using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Retry()
    {
        Time.timeScale=0.7f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ReturnToTitle()
    {
        Time.timeScale=0.7f;
        SceneManager.LoadScene(0);  //Loads the title screen (Scene 0)
    }
}
