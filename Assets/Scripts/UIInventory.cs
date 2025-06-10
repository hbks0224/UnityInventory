using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{

    //public GameObject[] Slots; //여러개 받기 위해 리스트또는 배열로
    //public GameObject E_Mark;
    //public GameObject ItemImageBox; slot스크립트안에 들어갈것

    public TextMeshProUGUI CurrentItem_text;
    public TextMeshProUGUI MaxItem_text;
    public int MaxItem = 9;
    public Button BackBtn;
    public int MaxItemValue;


    [SerializeField] private UISlot Slot;
    [SerializeField] private List<UISlot> SlotList = new List<UISlot>();

    [SerializeField] private Transform UiSlotTransform;
    private void Awake()
    {
        Debug.Log(UIManager.Instance);
        BackBtn.onClick.AddListener(UIManager.Instance.MainMenuScript.OpenMainMenu);
        
        //InitInventoryUI(GameManager.Instance.Player.Inventory);
        InitInventoryUI();
    }

    // public void InitInventoryUI(List<Item> itemList)
    public void InitInventoryUI()
    {
        for (int i = 0; i < MaxItemValue; i++)
        {
            UISlot uiSlot = Instantiate(Slot, UiSlotTransform);
            //uiSlot.SetItem(itemList[i]);
            SlotList.Add(uiSlot);
        }

    }

    public void SetItem(List<Item> items)
    {
        for (int i = 0; i < items.Count; i++)
        {
            SlotList[i].SetItem(items[i]);
        }
        
         //아이템이 여러개일경우 생각
    }

}
