using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public TextMeshProUGUI Atk_Text;
    public TextMeshProUGUI Dfe_Text;
    public TextMeshProUGUI Health_Text;
    public TextMeshProUGUI Critical_Text;

    public Button BackBtn;

    private void Start()
    {
        BackBtn.onClick.AddListener(UIManager.Instance.MainMenuScript.OpenMainMenu);
        DisplayStat();
    }
    public void DisplayStat()
    {

        Atk_Text.text = $"{GameManager.Instance.Player.Attack}";
        Dfe_Text.text = $"{GameManager.Instance.Player.Defense}";
        Health_Text.text = $"{GameManager.Instance.Player.Hp}";
        Critical_Text.text = $"{GameManager.Instance.Player.Critical}";
    }

    public void DisplayStat(Character player)
    {

        Atk_Text.text = $"{player.Attack}";
        Dfe_Text.text = $"{player.Defense}";
        Health_Text.text = $"{player.Hp}";
        Critical_Text.text = $"{player.Critical}";
    }
}
