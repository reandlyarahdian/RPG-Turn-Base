using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Perks/Move", fileName = "Move")]
public class MoveAction : ScriptableAction
{
    public GameObject game;
    public override void Act(StateComponent statesComponent)
    {
        statesComponent.GetComponent<IAssign>().AssignObj(game);
    }
}
