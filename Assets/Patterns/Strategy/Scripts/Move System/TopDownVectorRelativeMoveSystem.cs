using Patterns.Strategy.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy.MoveSystem
{
    public class TopDownVectorRelativeMoveSystem : MonoBehaviour, IMoveSystem
    {
        [SerializeField]
        private float _moveSpeed;
        [SerializeField]
        private float _rotateSpeed;

        public void Move(Transform transform, MoveData moveData)
        {
            if (moveData.MoveInput != Vector2.zero)
            {
                Vector3 cameraForward = Camera.main.transform.forward;
                Vector3 cameraRight = Camera.main.transform.right;

                cameraForward.y = 0;
                cameraRight.y = 0;

                cameraForward.Normalize();
                cameraRight.Normalize();

                Vector3 calculatedMovement = (cameraRight * moveData.MoveInput.x + cameraForward * moveData.MoveInput.y) * _moveSpeed * Time.deltaTime;
                Quaternion newRotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(calculatedMovement), _rotateSpeed * Time.deltaTime);

                transform.rotation = newRotation;
                transform.position += calculatedMovement;
            }
        }
    }
}