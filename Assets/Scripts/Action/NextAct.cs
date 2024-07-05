using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine;
using Assets.Scripts;

[CreateAssetMenu(menuName = "Scriptable Perks/choose", fileName = "choose")]
public class NextAct : ScriptableAction
{
    public int turn;

    public override void Act(StateComponent statesComponent)
    {
        statesComponent.GetComponent<GameManager>().NextTurn(turn);
    }
}