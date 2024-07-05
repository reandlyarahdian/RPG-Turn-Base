using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem;

namespace Assets.Scripts
{
    public class ChooseCondition: ScriptableCondition
    {
        public InputActionAsset inputActionAsset;
        public string actionName;
        private InputAction _inputAction;
        ButtonControl _button;

        private void OnEnable()
        {
            _inputAction = inputActionAsset.FindAction(actionName);
        }

        public override bool Verify(StateComponent statesComponent)
        {
            _button = _inputAction.activeControl as ButtonControl;
            if (_button != null)
            {
                return _button.isPressed;
            }

            return false;
        }
    }
}
