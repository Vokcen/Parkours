using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    Animator ani;
    public ParticleSystem rocket;
    public Vector3 roket;
    
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
            StartCoroutine(WaitBefore());


        }
    }
    IEnumerator WaitBefore()
    {
        Instantiate(rocket, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        

    }
}

