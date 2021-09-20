using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnSystem : MonoBehaviour
{
    public Vector3 checkpos;
    public GameObject player;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.position = checkpos;
            Debug.Log("Checkpos Çalıştı");
        }
       
    }



}
