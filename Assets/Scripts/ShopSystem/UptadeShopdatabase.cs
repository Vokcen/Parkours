using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="UptadeShopdatabase", menuName ="UptadingShop/  Uptade shop Database")]
public class UptadeShopdatabase : ScriptableObject
{
    public Player[] player;

    public int PlayerCount
    {
        get { return player.Length; }
    }
    public Player GetPower(int index)
    {
        return player[index];
    }
    public void purchasedPower(int index)
    {
        player[index].isPurchased = true;
    }
   
    
}
