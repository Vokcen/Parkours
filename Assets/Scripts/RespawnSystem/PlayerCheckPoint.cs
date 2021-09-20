using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{
    
    int currentCheckPoint;
    public RespawnSystem respawnSystem;



     void Start()
    {
          
    }
    void Update()
    {
        if (gameObject.transform.position.y<-20f)
        {
            gameObject.transform.position = respawnSystem.checkpos;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            respawnSystem.checkpos = other.transform.position;
            Debug.Log(("CheckpointTest" + transform.position));
          
        }
        if (other.gameObject.CompareTag("Respawner"))
        {
            
        }
    }
    }

