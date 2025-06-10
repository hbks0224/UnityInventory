using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{


    public TextMeshProUGUI ID_Text;
    public TextMeshProUGUI Level_Text;
    //public TextMeshProUGUI Current_Exp; UI상으로는 존재하나 안쓰는 거 같아서 일단 주석처리
    public TextMeshProUGUI Gold_Text;

    public Button StatusBtn;
    public Button InvenBtn;
    public UIStatus Status;

    private void Start()
    {
        OpenMainMenu();
        StatusBtn.onClick.AddListener(OpenStatus);
        InvenBtn.onClick.AddListener(OpenInventory);
        DisplayInfo();

    }
    public void OpenMainMenu()
    {
        UIManager.Instance.MainMenu.SetActive(true);
        UIManager.Instance.InventoryUI.SetActive(false);
        UIManager.Instance.StatusUI.SetActive(false);
        GameManager.Instance.Player.CheckEquip();
        Status.DisplayStat();

    }

    public void OpenStatus()
    {

        UIManager.Instance.StatusUI.SetActive(true);
        UIManager.Instance.InventoryUI.SetActive(false);
        UIManager.Instance.MainMenu.SetActive(false);
        

    }

    public void OpenInventory()
    {
        UIManager.Instance.MainMenu.SetActive(false);
        UIManager.Instance.StatusUI.SetActive(false);
        UIManager.Instance.InventoryUI.SetActive(true);
    }

    public void DisplayInfo()
    {
        ID_Text.text = $"{GameManager.Instance.Player.Name}";
        Level_Text.text = $"{GameManager.Instance.Player.Level}";
        Gold_Text.text =$"{GameManager.Instance.Player.Gold}";
    }

    public void DisplayInfo(Character player)
    {
        ID_Text.text = $"{player.Name}";
        Level_Text.text = $"{player.Level}";
        Gold_Text.text =$"{player.Gold}";
    }


}
