using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CameraSwitcher : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    //private Controller player;
     //CameraFollow cam;
     //Transform mainCam;
    //Animator ani;
    
  //  PlayableDirector director;

   // float smooth =5f;
    //float tiltAngle = 60.0f;
    void Start()
    {
       
      
       // director = GameObject.FindGameObjectWithTag("CamSwitch").GetComponent<PlayableDirector>();
        //player = GameObject.FindWithTag("Player").GetComponent<Controller>();
        //cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>();
      //  mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
    
       // director.enabled = false;

    }
    
    void Update()
    {
      
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CamSwitch();

        }
    }
        void CamSwitch()
    {
        /*    cam.Offset = new Vector3(0f, 4.08f, -7.3f);  // Camera Döndürme kodu,


            float x = 0f * tiltAngle;
            float y = 0f * tiltAngle;

            Quaternion target = Quaternion.Euler(x, y, 0f);

          mainCam.transform.rotation = Quaternion.Lerp(transform.rotation, target, Time.deltaTime * smooth);
        */
        cam1.enabled = false;
        cam2.enabled = true;
    }
    
}
