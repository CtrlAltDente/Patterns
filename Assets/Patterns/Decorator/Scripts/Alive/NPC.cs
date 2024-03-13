using Patterns.Decorator.Base;
using Patterns.Decorator.BuffsLogic;
using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.Alive
{
    public class NPC : MonoBehaviour, IAlive
    {
        public HealthSystem HealthSystem { get; private set; }
        public BuffSystem BuffSystem { get; private set; }

        private void Awake()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            HealthSystem = GetComponentInChildren<HealthSystem>();
            BuffSystem = GetComponentInChildren<BuffSystem>();

            foreach(IAliveSystem aliveSystem in GetComponentsInChildren<IAliveSystem>())
            {
                aliveSystem.SetAliveTarget(this);
            }
        }
    }
}
