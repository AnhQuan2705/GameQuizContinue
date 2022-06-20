using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

   
    public static float time;





    void Start()
    {
        time = 60;
    }

    void Update()
    {
        time -= Time.deltaTime;
    }




}
