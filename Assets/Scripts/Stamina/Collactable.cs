using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collactable : MonoBehaviour
{
    public StaminaBar staminaBar;
    public Controller con;


    void Start()
    {
        staminaBar = GameObject.FindGameObjectWithTag("Player").GetComponent<StaminaBar>();
        con = GameObject.FindGameObjectWithTag("Player").GetComponent<Controller>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            con.takeStamina(20f);   
            Destroy(gameObject);
        }
    }
}
