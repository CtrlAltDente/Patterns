using Patterns.StatePattern.StateLogic;
using Patterns.StatePattern.UnitLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Patterns.StatePattern
{
    public class UnitStateController : MonoBehaviour
    {
        [SerializeField]
        private UnitSelector _unitSelector;

        [SerializeField] 
        private StateSelector _stateSelector;

        public void DoStateOperationToUnit(InputAction.CallbackContext callbackContext)
        {
            if (!callbackContext.ReadValueAsButton() || !_unitSelector.Unit || !_stateSelector.CurrentState)
                return;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit raycastHit))
            {
                _stateSelector.CurrentState.DoStateLogic(raycastHit, _unitSelector.Unit);
            }
        }
    }
}