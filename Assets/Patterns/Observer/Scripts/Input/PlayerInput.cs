using JetBrains.Annotations;
using Patterns.Observer.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Patterns.Observer.Input
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField]
        private InputActionReference _moveAction;

        private List<IInputHandler> _inputHandlers = new List<IInputHandler>();

        private void Update()
        {
            SetInputToHandlers();
        }

        public void AddInputHandler(IInputHandler handler)
        {
            if (!_inputHandlers.Contains(handler))
            {
                _inputHandlers.Add(handler);
            }
        }

        public void RemoveInputHandler(IInputHandler handler)
        {
            if (_inputHandlers.Contains(handler))
            {
                _inputHandlers.Remove(handler);
            }
        }

        public void SetInputToHandlers()
        {
            InputData inputData = new InputData()
            {
                Move = _moveAction.action.ReadValue<Vector2>()
            };

            foreach (IInputHandler handler in _inputHandlers)
            {
                handler.SetInput(inputData);
            }
        }
    }
}