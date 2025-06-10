using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private string name;
    private Sprite icon;
    private bool isEquip;

    public string Name { get; private set; }
    public Sprite Icon { get; private set; }

    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Hp { get; private set; }
    public int Critical { get; private set; }
    public bool IsEquip  { get;  set; }
    public Item (string name, Sprite icon, int attack, int defense, int hp, int critical, bool isEquip)
    {


        Name = name;
        Icon = icon;
        Attack = attack;
        Defense = defense;
        Hp = hp;
        Critical = critical;
        IsEquip = isEquip;
    }

    public void SetEquip(bool equip)
    {
        IsEquip = equip;
    }

}
