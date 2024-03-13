using Patterns.Decorator.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.SpellsLogic
{
    public class SpellObject : MonoBehaviour
    {
        public Spell Spell;

        public void OnCollisionEnter(Collision collision)
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