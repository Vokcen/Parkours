using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopButtons : MonoBehaviour
{

    [SerializeField] GameObject ShopUI;

    public Player pr;

    Controller cr;


    void Start()
    {
        GenerateShop();
  

        cr = GameObject.FindGameObjectWithTag("Player").GetComponent<Controller>();
    }
    // Update is called once per frame
    void Update()
    {

    }
    void GenerateShop()
    {
     
    }


    public void OpenShopButton()
    {
        ShopUI.SetActive(true);
    }
    public void CloseShopButton()
    {
        ShopUI.SetActive(false);
    }

    public void BuyButton()
    {




    }
}

