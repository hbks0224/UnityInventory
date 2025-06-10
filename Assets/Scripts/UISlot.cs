using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{

    [SerializeField] private GameObject ItemImage;

    [SerializeField] private GameObject E_mark;
    [SerializeField] private bool isEquiped; //UI상으로 On/off 를 위한 bool
    public bool IsEquiped { get => isEquiped; set { isEquiped = value; RefreshUI(); } }
    private Item Currentitem; //현재 아이템 저장될 변수
    private Image itemImg;
    [SerializeField] private Sprite itemSprite;
    [SerializeField] private GameObject equipBtn;
    [SerializeField] private GameObject unequipBtn;



    void Start()
    {

    }

    private void Update()
    {
        RefreshUI();
    }

    public void SetItem(Item item)

    {
        Currentitem = item;
        itemImg = ItemImage.GetComponent<Image>();

        //Debug.Log($" 아이템 {item.Name}, 스프라이트 {item.Icon}");
        //Image img = ItemImage.GetComponent<Image>();
        //if (img != null)
        //    img.sprite = itemSprite;
        //Debug.Log(item.Icon);
        //Debug.Log(itemImg);
        itemImg.sprite = item.Icon;
        isEquiped = item.IsEquip;

        ItemImage.SetActive(true);
        RefreshUI();
    }


    public void RefreshUI() // ui갱신
    {

        if (isEquiped)
        {
            E_mark.SetActive(true);
        }
        else
        {
            E_mark.SetActive(false);
        }

    }
    public void Equip()
    {

        isEquiped = true;
        Currentitem.SetEquip(isEquiped);
        GameManager.Instance.Player.EquipItemList.Add(Currentitem);
        equipBtn.SetActive(false) ;
        unequipBtn.SetActive(true) ;
        GameManager.Instance.Player.CheckEquip();
        RefreshUI();


    }

    public void Unequip()
    {

        isEquiped = false;
        Currentitem.SetEquip(isEquiped); // 실제 장착 bool
        GameManager.Instance.Player.EquipItemList.Remove(Currentitem);
        GameManager.Instance.Player.CheckEquip();
        RefreshUI();
        equipBtn.SetActive(true);
        unequipBtn.SetActive(false);




    }

}
