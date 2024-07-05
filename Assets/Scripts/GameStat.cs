using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public interface IAction
{
    float Acts(float variable, Type type);
}

public interface IAssign
{
    void AssignObj(GameObject obj);
}

public enum Type
{
    Damage,
    Heal
}

public enum Play
{
    Player,
    Enemy
}

public enum Health
{
    Full,
    NotZero,
    Zero
}

public enum Mana
{
    Full,
    NotZero,
    Zero
}

[System.Serializable]
public class Stat
{
    public float Health;
    public float Energy;
}

[System.Serializable]
public class ExtraStat
{
    public float Defense;
    public float Exp;
    public float Range;
    public float Melee;
}
