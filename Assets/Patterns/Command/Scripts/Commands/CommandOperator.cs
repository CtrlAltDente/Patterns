using Patterns.CommandPattern.Base.TargetLogic;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Patterns.CommandPattern.Commands
{
    public class CommandOperator : MonoBehaviour
    {
        [SerializeField]
        private Command[] Commands;

        [SerializeField]
        private TextMeshProUGUI _castTime;

        [SerializeField]
        private TargetSelector _targetSelector;

        private Coroutine _castSpellCoroutine;

        public void RaiseCommand(Command command)
        {
            if (_targetSelector.SelectedTarget == null || command.InCooldown || _castSpellCoroutine != null)
                return;

            _castSpellCoroutine = StartCoroutine(WaitPrepareTimeAndCastSpell(command));
        }

        public IEnumerator WaitPrepareTimeAndCastSpell(Command command)
        {
            float waitTime = command.PrepareTime;

            while (waitTime > 0)
            {
                _castTime.text = waitTime.ToString();
                waitTime -= Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }

            _castTime.text = string.Empty;
            command.StartCommand(this, _targetSelector.SelectedTarget);

            DefaultSpellsCooldown();

            _castSpellCoroutine = null;
        }

        public void DefaultSpellsCooldown()
        {
            foreach (Command command in Commands)
            {
                command.SpellCooldown(this, 1f);
            }
        }
    }
}