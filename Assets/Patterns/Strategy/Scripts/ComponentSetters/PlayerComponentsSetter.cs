using Patterns.Strategy.Interfaces;
using Patterns.Strategy.MoveSystem;
using Patterns.Strategy.PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy.ComponentSetters
{
    public class PlayerComponentsSetter : MonoBehaviour
    {
        [SerializeField]
        private Player _player;

        [SerializeField]
        private GameObject _defaultMoveSystemGameObject;

        public IMoveSystem MoveSystem => _defaultMoveSystemGameObject.GetComponent<IMoveSystem>();

        private void Awake()
        {
            SetPlayerMoveSystem(MoveSystem);
        }

        public void SetPlayerMoveSystem(IMoveSystem moveSystem)
        {
            _player.SetMoveSystem(moveSystem);
        }
    }
}