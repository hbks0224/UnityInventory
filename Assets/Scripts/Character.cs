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

    public Character(string name, int level,int attack, int defense, int hp, int critical, int gold)
    {
        Name = name;
        Level = level;
        Attack = attack;
        Defense = defense;
        Hp = hp;
        Critical = critical;
        Gold = gold;
    }
}
