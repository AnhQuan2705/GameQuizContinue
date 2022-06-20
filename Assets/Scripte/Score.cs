using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    
    public static int scoreNumber;


    void Start()
    {

        PlayerPrefs.GetInt("Score", scoreNumber);
    }


    void Update()
    {

        PlayerPrefs.SetInt("Score", scoreNumber);
       

        if (PlayerPrefs.GetInt("HighScore") < scoreNumber)

            PlayerPrefs.SetInt("HighScore", scoreNumber);
    }
}
