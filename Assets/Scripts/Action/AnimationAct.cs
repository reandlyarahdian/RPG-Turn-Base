using Assets.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Perks/Animation", fileName = "Animation")]
public class AnimationAct : ScriptableAction
{
    public string Name;
    public override void Act(StateComponent statesComponent)
    {
        statesComponent.GetComponent<PlayerController>().Animate(Name);
    }
}
