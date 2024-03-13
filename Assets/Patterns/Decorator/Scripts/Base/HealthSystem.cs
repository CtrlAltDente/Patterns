using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Patterns.Decorator.Base
{
    public class HealthSystem : MonoBehaviour, IAliveSystem
    {
        public UnityEvent OnDeathEvent;

        [SerializeField]
        public int MaxHealth;
        [SerializeField]
        public int Health;

        public bool IsAlive => Health > 0;

        private IAlive _aliveTarget;

        private void Awake()
        {
            Health = MaxHealth;
        }

        public void SetAliveTarget(IAlive aliveTarget)
        {
            _aliveTarget = aliveTarget;
        }

        public void ReceiveDamage(int damage)
        {
            Health = Mathf.Clamp(Health - damage, 0, MaxHealth);

            if (Health == 0)
            {
                OnDeathEvent.Invoke();
            }
        }

        public void ReceiveHealing(int healing)
        {
            if (Health > 0)
            {
                Health = Mathf.Clamp(Health + healing, 1, MaxHealth);
            }
        }
    }
}