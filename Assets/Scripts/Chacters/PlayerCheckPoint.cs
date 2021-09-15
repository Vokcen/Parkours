using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{
    public GameObject checker;
    Vector3 spawnPoint;
    public GameObject spawner;
   

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y<-20f)
        {
            gameObject.transform.position = spawnPoint;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CheckPoint"))
        {
            spawnPoint = checker.transform.position;
            Debug.Log("Checklendi");
        }
        if (other.gameObject.CompareTag("Respawner"))
        {
            transform.position = spawner.transform.position;
        }
    }
    }

