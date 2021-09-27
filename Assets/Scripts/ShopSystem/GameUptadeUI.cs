using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameUptadeUI : MonoBehaviour
{
    [Header("Layout Settings")]
    [SerializeField] float itemSpacing = 0.5f;
    float itemHeight;

    [Header("Uı Elementss")]

    [SerializeField] Transform uptadeMEnu;
    [SerializeField] Transform uptadeItemsContainer;
    [SerializeField] GameObject itemPrefab;
    [Space(20)]
    [SerializeField] UptadeShopdatabase uptadeDb;

    [Header("Uptade Events")]
    [SerializeField] GameObject uptadeUI;
    [SerializeField] Button openUptadebutton;
    [SerializeField] Button closeUptadeButton;

     void Start()
    {
        AddUptadeEvents();
        GenerateUptadeItemsUI();
    }
     void GenerateUptadeItemsUI()
    {
        itemHeight = uptadeItemsContainer.GetChild(0).GetComponent<RectTransform>().sizeDelta.y;
        Destroy(uptadeItemsContainer.GetChild(0).gameObject);
        uptadeItemsContainer.DetachChildren();

        for (int i = 0; i < uptadeDb.PlayerCount; i++)
        {
            Player player = uptadeDb.GetPower(i);
            UptadeİtemUI uiItem = Instantiate(itemPrefab, uptadeItemsContainer).GetComponent<UptadeİtemUI>();

            uiItem.setItemPosition(Vector2.down * i * (itemHeight + itemSpacing));
           // uiItem.SetPlayerPrice(player.price);
          
            uiItem.SetPowersName(player.name);
            if (player.isPurchased)
            {
                uiItem.SetPowersPurchased();
                uiItem.OnItemSelect(i, OnItemSelected);
            }
            else
            {
          //      uiItem.SetPlayerPrice(player.price);
                uiItem.OnItemPurchase(i,OnItemPurchased);
            }
            uptadeItemsContainer.GetComponent<RectTransform>().sizeDelta =
                 Vector2.up * (itemHeight + itemSpacing) * uptadeDb.PlayerCount;
        }
    }
    void OnItemSelected(int index)
    {
        Debug.Log("select" + index);
    }
    void OnItemPurchased(int index)
    {
        Debug.Log("purchase" + index);
    }
    void AddUptadeEvents()
    {
        openUptadebutton.onClick.RemoveAllListeners();
        openUptadebutton.onClick.AddListener(openUptade);

        closeUptadeButton.onClick.RemoveAllListeners();
        closeUptadeButton.onClick.AddListener(closeUptade);
    }
    void openUptade()
    {
        uptadeUI.SetActive(true);
        Time.timeScale = 0;
    }
    void closeUptade()
    {
        uptadeUI.SetActive(false);
        Time.timeScale = 1;
    }
}
