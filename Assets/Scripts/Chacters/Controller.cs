using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Controller : MonoBehaviour

{
    public GameObject ski;
    public GameObject FinisPos;
    private Animator ani;
    public float speed, gravity, jumpforce,verticalvelocity;
    private CharacterController charcontrol;
    private bool onGround;
    

    private Vector3 move;
    private bool WallSlide;
    public  int dJump=2;
    public int currentJump = 0;
    


    void Start()
    {
        ani = GetComponent<Animator>();
        charcontrol = GetComponent<CharacterController>();
        Move(); 
    }

    // Update is called once per frame
    void Update()
    {
        move = Vector3.zero;
        move = transform.forward;
        if(charcontrol.isGrounded)
        {
            WallSlide = false;
            verticalvelocity = 0;
            if ( Input.GetMouseButtonDown(0))
            {
                verticalvelocity = jumpforce;
                ani.SetBool("Ledge", false);
                ani.SetTrigger("jump");
               


            }
          
        }
        if (!WallSlide)
        {
            verticalvelocity -= gravity * Time.deltaTime;
        }
        else
        {
            verticalvelocity -= gravity *0.4f* Time.deltaTime;
        }
        ani.SetBool("WallSlide", WallSlide);
        ani.SetBool("Grounded", charcontrol.isGrounded);
        move *= speed;
        move.y = verticalvelocity;
        charcontrol.Move(move*Time.deltaTime);
        
 
    }
 
        
    
    void Move()
    {
        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        switch (hit.gameObject.tag)
        {
            case "Jumper":
                jumpforce = 30f;            
                break;
            case "Ground":
                jumpforce = 10f;
            
                break;
        }

        if (hit.collider.tag=="Finish")
            {

            Debug.Log("deðdi");
                speed = 0;
                transform.position = FinisPos.transform.position;
                ani.SetBool("Finish", true);

            
        }
        if (hit.collider.tag=="Ledge")
        {
            ani.SetBool("Ledge", true);
            Debug.Log("Týrmanmaya çalýþtý");
        }
        if (hit.collider.tag=="wall")
        {
            
            if (verticalvelocity<-1f)
            {

                WallSlide = true;
            }
            if ( Input.GetMouseButtonDown(0))
            {
                verticalvelocity = jumpforce;
                
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 180, transform.eulerAngles.z);
             
                WallSlide = false;
                ani.SetBool("isJump", false);

            }

        }
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SkiStart")
        {
            ani.SetBool("Ski", true);
            ski.SetActive(true);
            
        }
        if (other.gameObject.tag == "SkiEnd")
        {
            ani.SetBool("Ski", false);
            ski.SetActive(false);

        }
    }





}
