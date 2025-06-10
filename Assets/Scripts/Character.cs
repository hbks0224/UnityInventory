using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character

{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Hp { get; private set; }
    public int Critical { get; private set; }
    public int Gold { get; private set; }
    public List<Item> Inventory = new List<Item>();
    public List<Item> EquipItemList = new List<Item>();
    public UISlot slot;
    public int tempHP { get; private set; }
    public int tempAttack { get; private set; }
    public int tempDefense { get; private set; }
    public int tempCritical { get; private set; }
    public Character(string name, int level, int attack, int defense, int hp, int critical, int gold)
    {
        Name = name;
        Level = level;
        Attack = attack;
        Defense = defense;
        Hp = hp;
        Critical = critical;
        Gold = gold;
        Inventory = new List<Item>();

        tempHP = hp;
        tempAttack = attack;
        tempDefense = defense;
        tempCritical = critical;


    }



    public void CheckEquip()
    {

        // 기본 스탯 으로 초기화 작업
        GameManager.Instance.Player.tempHP = GameManager.Instance.Player.Hp;
        GameManager.Instance.Player.tempAttack = GameManager.Instance.Player.Attack;
        GameManager.Instance.Player.tempDefense = GameManager.Instance.Player.Defense;
        GameManager.Instance.Player.tempCritical = GameManager.Instance.Player.Critical;

        foreach (var item in GameManager.Instance.Player.EquipItemList)
        {

            if (item.IsEquip)
            {
                //GameManager.Instance.Player.Hp += item.Hp;
                //GameManager.Instance.Player.Attack += item.Attack;
                //GameManager.Instance.Player.Critical += item.Critical;
                //GameManager.Instance.Player.Defense += item.Defense;

                GameManager.Instance.Player.tempHP += item.Hp;
                GameManager.Instance.Player.tempAttack += item.Attack;
                GameManager.Instance.Player.tempDefense += item.Defense;
                GameManager.Instance.Player.tempCritical += item.Critical;


            }
            //else
            //{
            //    GameManager.Instance.Player.Hp -= item.Hp;
            //    GameManager.Instance.Player.Attack -= item.Attack;
            //    GameManager.Instance.Player.Critical -= item.Critical;
            //    GameManager.Instance.Player.Defense -= item.Defense;

            //}
        }
        //GameManager.Instance.Player.Hp = tempHP;
        //GameManager.Instance.Player.Attack = tempAttack;
        //GameManager.Instance.Player.Defense = tempDefense;
        //GameManager.Instance.Player.Critical = tempCritical;



    }

    public void Equip()
    {
        slot.Equip();
    }

    public void Unequip()
    {
        slot.Unequip();
    }

    public void Additem(Item item)

    {

        Inventory.Add(item);

        Debug.Log($"아이템 추가{item.Name}");
    }



}
