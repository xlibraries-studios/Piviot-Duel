using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
//    private int count = 0;
//    private void Start()
//    {
//        if (count == 0)
//        {
//            PauseGame();
//            count++;
//        }
//        else if (count == 1)
//        {
//            ResumeGame();
//            count--;
//        }
//    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    //void ResumeGame()
    //{
    //    Time.timeScale = 1;
    //}
}
