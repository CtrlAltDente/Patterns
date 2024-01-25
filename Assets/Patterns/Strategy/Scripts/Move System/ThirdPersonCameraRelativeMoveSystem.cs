using JetBrains.Annotations;
using Patterns.Strategy.Interfaces;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Patterns.Strategy.MoveSystem
{
    public class ThirdPersonCameraRelativeMoveSystem : MonoBehaviour, IMoveSystem
    {
        [SerializeField]
        private float _moveSpeed;
        [SerializeField]
        private float _rotateSpeed;

        public void Move(Transform transform, MoveData moveData)
        {
            transform.rotation *= Quaternion.Euler(0, moveData.RotateInput.x * _rotateSpeed * Time.deltaTime, 0f);

            transform.position += (transform.forward * moveData.MoveInput.y + transform.right * moveData.MoveInput.x) * _moveSpeed * Time.deltaTime;
        }
    }
}