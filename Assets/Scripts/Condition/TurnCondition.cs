using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class TurnCondition : ScriptableCondition
    {
        public override bool Verify(StateComponent statesComponent)
        {
            return statesComponent.GetComponent<GameManager>().CurrentTurn();
        }
    }
}