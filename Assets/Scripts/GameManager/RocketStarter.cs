using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RocketStarter : MonoBehaviour
{
    Animator ani;
     void Start()
    { 
      
        ani = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
            
            Debug.Log("jetstart.");
            //    director.enabled = true;
            ani.SetBool("Fly", true);

}

        }
    }


