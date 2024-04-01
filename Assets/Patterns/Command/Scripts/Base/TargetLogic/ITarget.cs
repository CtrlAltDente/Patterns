using Patterns.CommandPattern.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.CommandPattern.Base.TargetLogic
{
    public interface ITarget
    {
        public Groups TargetGroup { get; }
    }
}
