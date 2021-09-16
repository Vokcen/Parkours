using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    Animator ani;
    public ParticleSystem rocket;
    
    
    void Start()
    {
        ani = GetComponent<Animator>();
        ani.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))  
        {
            ani.enabled = true;
            Instantiate(rocket, transform.position, transform.rotation);
            


        }
       
    }
   
    IEnumerator WaitBefore()
    {
        
     
        yield return new WaitForSeconds(0.1f);

    
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StopCoroutine(WaitBefore());

        }
    }
}

