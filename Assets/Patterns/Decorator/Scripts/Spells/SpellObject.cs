using Patterns.Decorator.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.SpellsLogic
{
    public class SpellObject : MonoBehaviour
    {
        public Action OnDestroyAction;



        public Spell Spell;

        private void OnCollisionEnter(Collision collision)
        {
            try
            {
                IAlive aliveTarget = collision.collider.GetComponent<IAlive>();
                Spell.ApplyToAlive(aliveTarget);
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }

            Destroy(gameObject);
        }

        private void OnDestroy()
        {
            OnDestroyAction?.Invoke();
        }

        public void CastSpellObject(Transform target)
        {
            StartCoroutine(MoveTo(target));
        }

        private IEnumerator MoveTo(Transform target)
        {
            while (isActiveAndEnabled)
            {
                transform.LookAt(target, Vector3.up);
                transform.position += transform.forward * 10 * Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
        }
    }
}