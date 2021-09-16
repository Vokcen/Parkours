using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketDestroy : MonoBehaviour
{
    float timeleft = 3;
    void Start()
    {
        
    }

    
    void Update()
    {
        timeleft -= Time.deltaTime;
        if (timeleft <= 0)
        {
            timeleft = 3;
            Destroy(gameObject);
        }
    }
}
