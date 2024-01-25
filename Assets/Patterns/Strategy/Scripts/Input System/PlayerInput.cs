using Patterns.Strategy.PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Patterns.Strategy.InputSystem
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField]
        private Player _player;

        [SerializeField]
        private InputActionReference _moveReference;
        [SerializeField]
        private InputActionReference _rotationReference;
        [SerializeField]
        private InputActionReference _jumpReference;

        public Vector2 MoveInput => _moveReference.action.ReadValue<Vector2>();
        public Vector2 RotationInput => _rotationReference.action.ReadValue<Vector2>();
        public bool JumpInput => _jumpReference.action.triggered;

        public void Update()
        {
            SetInputToPlayer();
        }

        private void SetInputToPlayer()
        {
            Debug.Log($"Move input: {MoveInput}, Rotation input: {RotationInput}, Jump: {JumpInput}");

            MoveData moveData = new MoveData() { MoveInput = MoveInput, RotateInput = RotationInput, JumpInput = JumpInput };
            _player.Move(moveData);
        }
    }
}