using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour
{
    public GameObject PressToStart;
    void Awake()
    {
        Time.timeScale = 0;
        
    }

 
    void Update()
    {
        Starter();
    }
    void Starter()  
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            PressToStart.SetActive(false);
        }
    }
}
