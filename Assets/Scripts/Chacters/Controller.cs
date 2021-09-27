using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;
using TMPro;

public class Controller : MonoBehaviour

{
    public Player pl;
    public GameObject ski;
    public GameObject FinisPos;
    private Animator ani;
    public float speed, gravity, jumpforce, verticalvelocity;
    private CharacterController charcontrol;
    private bool onGround;
    private Vector3 move;
    private bool WallSlide;

    // PlayableDirector director;
    // Stamina Göstergeleri------------------------------------------
    public float maxStamina = 100;
    public float currentStamina;
    public StaminaBar staminaBar;
    public RespawnSystem rs;
    [SerializeField] TMP_Text staminaSpeed;
    [SerializeField] TMP_Text maxStaminaText;
    //PlayerCheckPoint ck;
    // public RespawnSystem rs;

    void Start()
    {
     
        //rs = GameObject.FindGameObjectWithTag("Death").GetComponent<RespawnSystem>();
        //ck = GetComponent<PlayerCheckPoint>();
        currentStamina = maxStamina;
        staminaBar.MaxStamina(maxStamina);
        ani = GetComponent<Animator>();
        charcontrol = GetComponent<CharacterController>();
        //   director = GetComponent<PlayableDirector>();
        // director.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        StaminaSpeed();
        StaminaText();
        Move();
        lessStamina(9);


        if (currentStamina > 100)
        {
            Debug.Log("test");
            currentStamina = 100;
        }

        if (currentStamina <= 0)
        {
            gameObject.transform.position = rs.checkpos;
            currentStamina += 50;


            Debug.Log("Çalışıyor" + transform.position);

        }


    }

    void Move()
    {
        move = Vector3.zero;
        move = transform.forward;
        if (charcontrol.isGrounded)
        {
            WallSlide = false;
            verticalvelocity = 0;
            if (Input.GetMouseButtonDown(0))
            {
                verticalvelocity = jumpforce;
                ani.SetBool("Ledge", false);
                ani.SetTrigger("Jump");



            }

        }
        if (!WallSlide)
        {
            verticalvelocity -= gravity * Time.deltaTime;
        }
        else
        {
            verticalvelocity -= gravity * 0.4f * Time.deltaTime;
        }
        ani.SetBool("WallSlide", WallSlide);
        ani.SetBool("Grounded", charcontrol.isGrounded);
        move *= speed;
        move.y = verticalvelocity;
        charcontrol.Move(move * Time.deltaTime);

    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        switch (hit.gameObject.tag)
        {
            case "Jumper":
                jumpforce = 30f;
                break;

                ;
            case "Ground":
                jumpforce = 10f;

                break;
        }
        if (hit.collider.tag == "Jumper2")
        {
            jumpforce = 60f;
        }

        if (hit.collider.tag == "Finish")
        {

            Debug.Log("değdi");
            speed = 0;
            transform.position = FinisPos.transform.position;
            ani.SetBool("Finish", true);


        }
        if (hit.collider.tag == "CamSwitch")
        {
            //   director.enabled=true;
        }
        if (hit.collider.tag == "Ledge")
        {
            ani.SetBool("Ledge", true);

        }
        if (hit.collider.tag == "wall")
        {

            if (verticalvelocity < -1f)
            {

                WallSlide = true;
            }
            if (Input.GetMouseButtonDown(0))
            {
                verticalvelocity = jumpforce;

                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 180, transform.eulerAngles.z);

                WallSlide = false;


            }

        }

        if (hit.collider.tag == "StaminaLose")
        {
            lessStamina(30 * Time.deltaTime);
            Debug.Log("StamineLoses");
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
        if (other.gameObject.tag == "StaminaAdd")
        {
            takeStamina(40);
            Debug.Log("StaminaAdded");
        }
        if (other.gameObject.tag == "StaminaMaxer")
        {
            takeStamina(80);
            Debug.Log("Staminmaxed");
        }
        if (other.gameObject.tag == "Gold")
        {
            pl.gold++;
        }
    }


    public virtual void takeStamina(float take)
    {
        currentStamina += take;
        staminaBar.SetStamina(currentStamina);
    }
    public void lessStamina(float less)
    {
        currentStamina -= less * Time.deltaTime;
        staminaBar.SetStamina(currentStamina);
       
    }
    public void StaminaText()
    {
        maxStaminaText.text = maxStamina.ToString();
    }
    public void StaminaSpeed()
    {

        staminaSpeed.text = currentStamina.ToString("0");
    }


}
