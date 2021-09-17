using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RocketStarter : MonoBehaviour
{
    Controller p;
    Animator ani;
     void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Controller>();
        ani = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            p.jumpforce = 60f;
            p.gravity = 5;
            Debug.Log("jetstart.");
            //    director.enabled = true;
            ani.SetBool("Fly", true);

}

        }
    
    }


