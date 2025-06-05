using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializedField] public UIManager uiManager;

    private Character player;
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

        SetData();
    }

    public void SetData()
    {

         player = new Character("장혁준", 30,25, 30, 30, 30, 10000);


    }

    public Character Player => player;
}
