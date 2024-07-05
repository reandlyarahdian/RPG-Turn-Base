using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class EndCondition : ScriptableCondition
    {

        public Health checkStatus;

        public override bool Verify(StateComponent statesComponent)
        {
            return checkStatus == statesComponent.GetComponent<StatComponent>().GetHealth();
        }
    }
}
