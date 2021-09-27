using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateShopSystem : MonoBehaviour
{
    //test
    public int currentPrice;
    [Header("Layout Settings")]
    [SerializeField] float itemSpacing = 0.5f;
    float itemHeight;
    int prefabCount = 3;
    [Space(20)]
    [SerializeField] UptadeShopdatabase uptadeDb;
    [Header("Uı Elementss")]

    [SerializeField] Transform uptadeMEnu;
    [SerializeField] Transform uptadeItemsContainer;
    [SerializeField] GameObject itemPrefab;
    [Space(20)]
  

    [Header("Uptade Events")]
    [SerializeField] GameObject uptadeUI;
    [SerializeField] Button openUptadebutton;
    [SerializeField] Button closeUptadeButton;


    void Start()
    {
        GenerateUptadeItemsUI();
        AddUptadeEvents();

    }
    void GenerateUptadeItemsUI()
    {
        itemHeight = uptadeItemsContainer.GetChild(0).GetComponent<RectTransform>().sizeDelta.y;
        Destroy(uptadeItemsContainer.GetChild(0).gameObject);
        uptadeItemsContainer.DetachChildren();

        for (int i = 0; i < uptadeDb.PlayerCount    ; i++)
        {
            Player player = uptadeDb.GetPower(i);
            UptadeUI uiItem = Instantiate(itemPrefab, uptadeItemsContainer).GetComponent<UptadeUI>();

       //     uiItem.SetUptadePrice (player.price);
          
            uiItem.SetUptadeValue(player.value);
            if (player.isPurchased)
            {
               uiItem.SetPowersPurchased();   


            }
            else
            {
            //    uiItem.SetUptadePrice(player.price);
               
            }
            uptadeItemsContainer.GetComponent<RectTransform>().sizeDelta =
                 Vector2.up * (itemHeight + itemSpacing) * uptadeDb.PlayerCount;
        }
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
    void UptadeSystem()
    {
       
    }
}
