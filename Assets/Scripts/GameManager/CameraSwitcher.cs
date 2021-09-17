using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{

    private Controller player;
     CameraFollow cam;
     Transform mainCam;
    Animator ani;
    

    float smooth =5f;
    float tiltAngle = 60.0f;
    void Start()
    {

        player = GameObject.FindWithTag("Player").GetComponent<Controller>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>();
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        ani = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();

    }
    void Update()
    {
      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("jetstart.");
            CamSwitch();


        }
    }
    void CamSwitch()
    {
        player.speed = 0;
        cam.Offset = new Vector3(0f, 4.08f, -7.3f);


        float x = 0f * tiltAngle;
        float y = 0f * tiltAngle;

        Quaternion target = Quaternion.Euler(x, y, 0f);

      mainCam.transform.rotation = Quaternion.Lerp(transform.rotation, target, Time.deltaTime * smooth);

    }
}
