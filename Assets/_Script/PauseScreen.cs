using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public void ResumeGame()
    {
        
    }
    public void ReturnToTitle()
    {
        SceneManager.LoadScene(0);  //Loads the title screen (Scene 0)
    }
}
