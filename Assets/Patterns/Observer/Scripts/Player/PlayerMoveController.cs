using Patterns.Observer.Input;
using Patterns.Observer.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer.Player
{
    public class PlayerMoveController : MonoBehaviour, IInputHandler
    {
        [SerializeField]
        private float _moveSpeed;
        [SerializeField]
        private float _rotateSpeed;

        [SerializeField]
        private PlayerInput _playerInput;

        [SerializeField]
        private Transform _player;

        private void Awake()
        {
            _playerInput.AddInputHandler(this);
        }

        public void SetInput(InputData inputData)
        {
            if (inputData.Move == Vector2.zero)
                return;

            Vector3 moveDirection = new Vector3(inputData.Move.x, 0, inputData.Move.y) * Time.deltaTime;

            Quaternion newRotation = Quaternion.RotateTowards(_player.rotation, Quaternion.LookRotation(moveDirection), _rotateSpeed * Time.deltaTime);

            _player.rotation = newRotation;
            _player.transform.position += moveDirection;
        }
    }
}
