using Patterns.TemplateMethod.Base.Units;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.TemplateMethod.Base.Attack
{
    public abstract class WeaponAttack : MonoBehaviour
    {
        [SerializeField]
        protected int _damage;
        [SerializeField]
        private int _attackRange;
        [SerializeField]
        private float _waitTime;
        [SerializeField]
        private bool _canAttack = true;

        private Coroutine _waitAttackCoroutine;

        public void Attack(Unit unit)
        {
            bool targetUnitInRange = Vector3.Distance(transform.position, unit.transform.position) < _attackRange;

            if (!targetUnitInRange || !_canAttack)
                return;

            PlayAnimation();
            DoAttackLogic(unit);
            WaitAttackPause(_waitTime);
        }

        private void PlayAnimation()
        {
            Debug.Log("Play animiation");
        }

        protected abstract void DoAttackLogic(Unit unit);

        private void WaitAttackPause(float waitTime)
        {
            if(_waitAttackCoroutine == null)
            {
                _waitAttackCoroutine = StartCoroutine(WaitAttack(waitTime));
            }
        }

        private IEnumerator WaitAttack(float waitTime)
        {
            _canAttack = false;
            yield return new WaitForSeconds(waitTime);
            _canAttack = true;

            _waitAttackCoroutine = null;
        }
    }
}
