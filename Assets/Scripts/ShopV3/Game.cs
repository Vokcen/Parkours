using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    public TMP_Text ui;
 public void Increment()
    {
        GameManager.gold += GameManager.multiplier;
    }
    public void Buy(int num)
    {
        if (num==1 && GameManager.gold>=25)
        {
            GameManager.multiplier += 1;
            GameManager.gold -= 25;
        }
       
        
    }
     void Update()
    {
        ui.text = "$:" + GameManager.gold;
    }
}