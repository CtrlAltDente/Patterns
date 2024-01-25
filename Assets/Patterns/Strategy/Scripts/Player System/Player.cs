using Patterns.Strategy.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy.PlayerSystem
{
    public class Player : MonoBehaviour
    {
        private IMoveSystem MovableSystem;

        public void SetMoveSystem(IMoveSystem movableSystem)
        {
            MovableSystem = movableSystem;
        }

        public void Move(MoveData moveData)
        {
            MovableSystem.Move(transform, moveData);
        }
    }
}