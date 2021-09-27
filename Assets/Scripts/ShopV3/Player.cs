using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Player : MonoBehaviour
{
    public int speedPrice;
    public int maxStaminaPrice;
    public int staminaSpeedPRice;
    public bool isPurchased;
    public int value;
    public int gold;
    public GameObject ShopUI;
    [SerializeField] TMP_Text powerPrice;
    [SerializeField] TMP_Text playerGold;
    [SerializeField] TMP_Text playergold2;
    [SerializeField] TMP_Text maxstaminatext;
    [SerializeField] TMP_Text staminaspeedtext;
   public Button buybtn;
    public Button buybtn2;
    public Button buybtn3;
    Controller cr;
     void Start()
    {
        cr = GameObject.FindGameObjectWithTag("Player").GetComponent<Controller>();
        buybtn.onClick.AddListener(BuyClick);
        buybtn2.onClick.AddListener(BuyClick2);
        buybtn3.onClick.AddListener(BuyClick3);

        gold = PlayerPrefs.GetInt("gold");

        speedPrice = PlayerPrefs.GetInt("speedPrice");
        maxStaminaPrice = PlayerPrefs.GetInt("maxStaminaPrice");
        staminaSpeedPRice = PlayerPrefs.GetInt("staminaSpeedPRice");
    }

    public void Update()
    {
        setprice();

        setgold();
        SetmaxStaminaPrice();
        SetStaminaSpeed();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("gold", gold);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.DeleteAll();

            }

        }  

    }

    public void  setgold()
    {
        playerGold.text = gold.ToString();
        playergold2.text = gold.ToString();
       
        PlayerPrefs.SetInt("gold", gold);
      
    }
    public void setprice()
    {
        powerPrice.text = speedPrice.ToString();
        PlayerPrefs.SetInt("speedPrice", speedPrice);

    }
    public void SetmaxStaminaPrice()
    {
        maxstaminatext.text = maxStaminaPrice.ToString();
        PlayerPrefs.SetInt("maxStaminaPrice", maxStaminaPrice);


    }
    public void SetStaminaSpeed()
    {
        staminaspeedtext.text = staminaSpeedPRice.ToString();
        PlayerPrefs.SetInt("staminaSpeedPRice", staminaSpeedPRice);
    }
    void BuyClick()
    {
        if (speedPrice < gold)
        {
            gold -= speedPrice;
            speedPrice *= 2;
            cr.speed += 0.5f;


        }
       
   
    }
    void BuyClick2()
    {
        if (maxStaminaPrice < gold)
        {
            gold -= maxStaminaPrice;
            maxStaminaPrice *= 3;
            cr.maxStamina += 25;
        }
    }
    void BuyClick3()
    {
        if (staminaSpeedPRice < gold)
        {
            gold -= staminaSpeedPRice;
            staminaSpeedPRice *= 3;
            cr.lessStamina(-1);
        }
    }
       public void OpenShopButton()
    {
        ShopUI.SetActive(true);
    }
    public void CloseShopButton()
    {
        ShopUI.SetActive(false);
    }

    
    




}
