using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour
{
    public float speed= 10;
    float timeLeft = 5f;
    void Start()    
    {
        
    }

   
    void FixedUpdate()
    {
        transform.Rotate(0, 1, 0 * speed);
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            speed = 50;
            transform.Rotate(0, 1, 0 * speed); 
        }
    }
}
