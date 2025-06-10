using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] public UIManager uiManager;

    private Character player;
    //private Item testItem;
    [SerializeField] private Sprite testIcon;
    [SerializeField] private Sprite testIcon2;
    [SerializeField] private Sprite testIcon3;
    [SerializeField] private Sprite testIcon4;
    [SerializeField] private Sprite testIcon5;
    [SerializeField] private Sprite testIcon6;
    [SerializeField] private Sprite testIcon7;
    public UIInventory uiInventory;



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {

            Destroy(gameObject);
        }

    }
    private void Update()
    {

    }
    private void Start()
    {
        SetData();

    }

    public void SetData() //데이터 준비
    {

        player = new Character("장혁준", 0, 0, 0, 0, 0, 10000);
        List<Item> itemsdata = new List<Item>()
        {


             new Item("테스트", testIcon, 3, 4, 5, 6,false),
             new Item("테스트2", testIcon2, 33, 34, 35, 36,false),
             new Item("테스트3", testIcon3, 353, 344, 35, 36, false),
             new Item("테스트4", testIcon4, 343, 34, 35, 36, false),
             new Item("테스트5", testIcon5, 333, 34, 35, 36, false),
             new Item("테스트6", testIcon6, 313, 34, 35, 36, false),
             new Item("테스트7", testIcon7, 323, 34, 35, 36, false)


        };

        for(int i = 0; i<itemsdata.Count; i++)
        {
            player.Additem(itemsdata[i]); //인벤토리에 아이템 추가

        }
        uiInventory.SetItem(itemsdata);




    }

    public Character Player => player;


}
