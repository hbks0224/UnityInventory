using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject statusUI;
    [SerializeField] private GameObject inventoryUI;
    public GameObject MainMenu => mainMenu;
    public GameObject InventoryUI => inventoryUI;
    public GameObject StatusUI => statusUI;


    public UIMainMenu MainMenuScript { get; private set; }
    public UIStatus StatusScript { get; private set; }
    public UIInventory InventoryScript { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            MainMenuScript = mainMenu.GetComponent<UIMainMenu>();
            StatusScript = statusUI.GetComponent<UIStatus>();
            InventoryScript = inventoryUI.GetComponent<UIInventory>();
        }
        else
        {

            Destroy(gameObject);
        }

       

    }




}
