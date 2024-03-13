using Patterns.Decorator.BuffsLogic;
using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.Base
{
    public class BuffSystem : MonoBehaviour, IAliveSystem
    {
        private IAlive _aliveTarget;

        [SerializeField]
        private List<Buff> _activeBuffs = new List<Buff>();

        private void Start()
        {
            StartCoroutine(ApplyBuffsCoroutine());
        }

        public void SetAliveTarget(IAlive aliveTarget)
        {
            _aliveTarget = aliveTarget;
        }

        public void AddBuff(Buff buff)
        {
            _activeBuffs.Add(buff);
        }

        private IEnumerator ApplyBuffsCoroutine()
        {
            List<Buff> buffsToRemove = new List<Buff>();

            while (_aliveTarget.HealthSystem.IsAlive)
            {
                foreach (Buff buff in _activeBuffs)
                {
                    buff.UseBuffToAlive(_aliveTarget);

                    if (!buff.IsActive)
                    {
                        buffsToRemove.Add(buff);
                    }
                }

                foreach (Buff buff in buffsToRemove)
                {
                    _activeBuffs.Remove(buff);
                }

                buffsToRemove.Clear();
                yield return new WaitForSeconds(1);
            }
        }
    }
}