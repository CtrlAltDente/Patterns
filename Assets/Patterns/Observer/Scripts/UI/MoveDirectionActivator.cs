using Patterns.Observer.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer.UI
{
    public class MoveDirectionActivator : MonoBehaviour
    {
        [SerializeField]
        private MoveDirectionDebugger _moveDirectionDebugger;

        [SerializeField]
        private PlayerInput _playerInput;

        public void SetActiveDebug(bool isActive)
        {
            if (isActive)
            {
                _playerInput.AddInputHandler(_moveDirectionDebugger);
            }
            else
            {
                _playerInput.RemoveInputHandler(_moveDirectionDebugger);
            }
        }
    }
}