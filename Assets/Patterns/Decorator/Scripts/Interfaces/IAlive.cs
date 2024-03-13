using Patterns.Decorator.Base;
using Patterns.Decorator.BuffsLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.Interfaces
{
    public interface IAlive
    {
        public HealthSystem HealthSystem { get; }
        public BuffSystem BuffSystem { get; }
    }
}