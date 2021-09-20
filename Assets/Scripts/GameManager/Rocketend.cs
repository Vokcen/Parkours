using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketend : MonoBehaviour
{
    Controller p;
    Animator ani;
    public GameObject rocket;
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Controller>();
        ani = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            rocket.SetActive(false);
            ani.SetBool("Fly", false);
            Debug.Log("JetEnd");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
