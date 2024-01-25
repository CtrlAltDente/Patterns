using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy.Interfaces
{
    public interface IMoveSystem
    {
        public void Move(Transform transform, MoveData moveData);
    }
}