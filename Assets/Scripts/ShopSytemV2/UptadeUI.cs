using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class UptadeUI : MonoBehaviour
{
    [SerializeField] Image powersImage;
    [SerializeField] TMP_Text uptadePrice;
    [SerializeField] TMP_Text uptadeValue;
    [SerializeField] Button powerPurchaseButton;
    public void setItemPosition(Vector2 pos)
    {
        GetComponent<RectTransform>().anchoredPosition += pos;
    }
    public void SetPowersImage(Sprite sprite)
    {
        powersImage.sprite = sprite;
    }
   public void SetUptadePrice(int price)
    {
        uptadePrice.text = price.ToString();
    }
   public void SetUptadeValue(int value)
    {
        uptadeValue.text = value.ToString();
    }
    public void SetPowersPurchased()
    {

        SetUptadeValue(+3);
    }
    public void OnItemPurchase(int ItemIndex, UnityAction<int> action)
    {
        powerPurchaseButton.onClick.RemoveAllListeners();
        powerPurchaseButton.onClick.AddListener(() => action.Invoke(ItemIndex));


    }
}
