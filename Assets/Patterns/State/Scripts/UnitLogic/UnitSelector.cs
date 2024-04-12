using Patterns.StatePattern.StateLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Patterns.StatePattern.UnitLogic
{
    public class UnitSelector : MonoBehaviour
    {
        public Unit Unit { get; private set; }

        public void SelectUnit(InputAction.CallbackContext callbackContext)
        {
            if (!callbackContext.ReadValueAsButton())
                return;

            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Debug.Log($"Hit: {hit.collider.gameObject.name}");

                if (Unit != null)
                {
                    Unit.IsSelected = false;
                }

                Unit selectedUnit = hit.collider.GetComponentInChildren<Unit>();

                if (selectedUnit != null)
                {
                    Unit = selectedUnit;
                    Unit.IsSelected = true;
                }
            }
        }
    }
}