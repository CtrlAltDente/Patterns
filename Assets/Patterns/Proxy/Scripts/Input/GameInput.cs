using Patterns.Proxy.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Patterns.Proxy.Input
{
    public class GameInput : MonoBehaviour
    {
        private IMovable _unitMovePart;

        public void Start()
        {
            _unitMovePart = GetComponentInChildren<IMovable>();
        }

        public void HandleMoveInput(InputAction.CallbackContext callbackContext)
        {
            Vector3 moveDirection = new Vector3(callbackContext.ReadValue<Vector2>().x, 0, callbackContext.ReadValue<Vector2>().y);
            _unitMovePart.Move(moveDirection);
        }
    }
}