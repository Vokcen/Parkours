using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
public class UptadeİtemUI : MonoBehaviour
{
    [Space(20f)]
    [SerializeField] Image playerPowersImage;
    [SerializeField] TMP_Text playerName;
    [SerializeField] TMP_Text playerPrice;
    [SerializeField] Button powersPurchaseButton;
 
    [Space(20f)]
    [SerializeField] Button itembutton;
    [SerializeField] Image itemImage;
    [SerializeField] Outline itemOutline;

    //------------------------------------------------------------

    public void setItemPosition(Vector2 pos)
    {
        GetComponent<RectTransform>().anchoredPosition += pos;
    }
    public void SetPowersImage(Sprite sprite)
    {
        playerPowersImage.sprite = sprite;    
    }
    public void SetPowersName(string name)
    {
        playerName.text = name;
    }
    public void SetPlayerPrice(int price)
    {
        playerPrice.text = price.ToString();   
    }
    public void SetPowersPurchased()
    {
    
        itembutton.interactable = true;
      
    }
    public void OnItemPurchase(int ItemIndex,UnityAction<int> action)
    {
        powersPurchaseButton.onClick.RemoveAllListeners();
        powersPurchaseButton.onClick.AddListener(() => action.Invoke(ItemIndex));
        

    }
    public void OnItemSelect(int ItemIndex, UnityAction<int> action)
    {
        powersPurchaseButton.onClick.RemoveAllListeners();
        powersPurchaseButton.onClick.AddListener(() => action.Invoke(ItemIndex));


    }
    public void SelectItem()
    {
        itemOutline.enabled = true;
        itembutton.interactable = false;
    }
    public void DeSelectItem()
    {
        itemOutline.enabled = false;
        itembutton.interactable = true;
    }

}
