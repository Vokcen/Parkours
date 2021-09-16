using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
        
        void Start()
    {
        
    }
    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            Debug.Log("jetstart.");
            CamSwitch(); 
        }
    }
    void CamSwitch()
    {
        cam1.enabled = false;
        cam2.enabled = true;
    }
}
