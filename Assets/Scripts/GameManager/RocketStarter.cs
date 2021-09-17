using System.Collections;
using System.Collections.Generic;
using UnityEngine;
un

public class RocketStarter : CameraSwitcher
{
   public  CameraSwitcher cam;
     void Start()
    { 
        cam=Game
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("jetstart.");
            //    director.enabled = true;
            CamSwitch();
            ani.SetBool("Fly", true);


        }
    }
