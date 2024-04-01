using Patterns.CommandPattern.Base.TargetLogic;
using Patterns.CommandPattern.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.CommandPattern.Commands
{
    public abstract class Command : ScriptableObject
    {
        [SerializeField]
        private bool _inCooldown;

        public float PrepareTime;
        public float Cooldown;

        public abstract Groups CommandTarget { get; }
        public virtual bool InCooldown => _inCooldown;

        public void StartCommand(MonoBehaviour commandOwner, ITarget target)
        {
            SpellLogic(target);
            SpellCooldown(commandOwner, Cooldown);
        }

        public void SpellCooldown(MonoBehaviour commandOwner, float time)
        {
            if (!InCooldown && time > 0)
            {
                commandOwner.StartCoroutine(CooldownCoroutine(time));
            }
        }

        protected abstract void SpellLogic(ITarget target);

        private IEnumerator CooldownCoroutine(float seconds)
        {
            _inCooldown = true;
            yield return new WaitForSeconds(seconds);
            _inCooldown = false;
        }
    }
}
