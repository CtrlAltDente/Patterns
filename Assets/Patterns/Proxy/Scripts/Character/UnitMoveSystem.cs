using Patterns.Proxy.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Proxy.Unit
{
    public class UnitMoveSystem : MonoBehaviour, IMovable
    {
        [SerializeField]
        private GameObject _unitGameObject;

        private IMovable _unit;

        private void Start()
        {
            _unit = _unitGameObject.GetComponent<IMovable>();
        }

        public void Move(Vector3 moveDirection)
        {
            Debug.Log("Calculate new direction");
            
            _unit.Move(moveDirection);
        }
    }
}