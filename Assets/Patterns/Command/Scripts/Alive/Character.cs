using Patterns.CommandPattern.Base.TargetLogic;
using Patterns.CommandPattern.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.CommandPattern.Alive
{
    public class Character : MonoBehaviour, ITarget
    {
        [SerializeField]
        public Groups _group;

        public Groups TargetGroup => _group;
    }
}