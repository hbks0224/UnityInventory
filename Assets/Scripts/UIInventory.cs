using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{

    public GameObject[] Slots; //여러개 받기 위해 리스트또는 배열로
    //public GameObject E_Mark;
    //public GameObject ItemImageBox; slot스크립트안에 들어갈것

    public TextMeshProUGUI CurrentItem_text;
    public TextMeshProUGUI MaxItem_text;
    public int MaxItem = 9;
    public Button BackBtn;

    private void Start()
    {
        BackBtn.onClick.AddListener(UIManager.Instance.MainMenuScript.OpenMainMenu);
         
    }

}
