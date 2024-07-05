using Assets.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Perks/Action", fileName = "Action")]
public class BaseDamage : ScriptableAction
{
    public float baseVar;

    public Type baseType;

    public override void Act(StateComponent statesComponent)
    {
        statesComponent.GetComponent<IAction>().Acts(baseVar, baseType);

    }
}
