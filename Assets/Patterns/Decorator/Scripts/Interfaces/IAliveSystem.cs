using Patterns.Decorator.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.Interfaces
{
    public interface IAliveSystem
    {
        void SetAliveTarget(IAlive aliveTarget);
    }
}