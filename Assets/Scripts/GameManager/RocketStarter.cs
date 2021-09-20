using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RocketStarter : MonoBehaviour
{
    Controller p;
    Animator ani;
     Transform player;
    public GameObject rocket;
     void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Controller>();
        ani = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }



    private void OnTriggerStay(Collider other)
    {
        
    
        if (other.gameObject.tag == "Player")
        {
            rocket.SetActive(true);
            p.jumpforce = 80f;
            p.gravity = 40;
            Debug.Log("jetstart.");
            //    director.enabled = true;
            ani.SetBool("Fly", true);
         /*   float açı = -50;
            Vector3 to = new Vector3(açı, 0, 0);

            player.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
            Debug.Log("döndü");*/
}

        }

   
    
    }


