using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{

    private Controller player;
    public CameraFollow cam;
    public Transform mainCam;
    public Transform target;

    void Start()
    {

        player = GameObject.FindWithTag("Player").GetComponent<Controller>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>();
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();



    }
    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(target);

        // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        transform.LookAt(target, Vector3.left);
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
        cam.Offset = new Vector3(-0.32f, 4.08f, -6.63f);
        mainCam.transform.Rotate(0.0f, 90f, 0.0f);


    }
}
