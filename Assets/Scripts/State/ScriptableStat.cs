using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Scriptable Perks/Stats", fileName = "Stats")]
public class ScriptableStat : ScriptableObject
{
    public Stat stat;
    public ExtraStat extraStat;
    public Image healthBar;
    public Image manaBar;
}
