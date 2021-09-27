using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
public class ShopUI : MonoBehaviour
{
    [Space(20f)]

    [SerializeField] TMP_Text playerName;
    [SerializeField] TMP_Text playerPrice;



    //------------------------------------------------------------



    
    public void SetPlayerPrice(int price)
    {
        playerPrice.text = price.ToString();
    }





}
