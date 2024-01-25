using Patterns.Strategy.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy.ComponentSetters
{
    public class MoveSystemSetter : MonoBehaviour
    {
        [SerializeField]
        private PlayerComponentsSetter _playerComponentsSetter;

        [SerializeField]
        private IMoveSystem _moveSystem => GetComponentInChildren<IMoveSystem>();

        public void SetMoveSystem()
        {
            _playerComponentsSetter.SetPlayerMoveSystem(_moveSystem);
        }
    }
}