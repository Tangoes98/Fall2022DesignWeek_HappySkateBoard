using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTutorial : MonoBehaviour
{
    int imgIndex = 0;

    [SerializeField]
    GameObject[] tutorial;

    public void NextTutorialImage()
    {
        if(imgIndex < 6)
        {
            tutorial[imgIndex + 1].SetActive(true);
            tutorial[imgIndex].SetActive(false);
            imgIndex++;
        }
        else
        {
            imgIndex = 0;
            tutorial[6].SetActive(false);
            tutorial[imgIndex].SetActive(true);
        }
    }
    
    public void PreviousTutorialImage()
    {
        if(imgIndex > 0)
        {
            tutorial[imgIndex - 1].SetActive(true);
            tutorial[imgIndex].SetActive(false);
            imgIndex--;
        }
        else
        {
            imgIndex = 6;
            tutorial[0].SetActive(false);
            tutorial[imgIndex].SetActive(true);
        }
    }
}
