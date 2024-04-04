using Patterns.TemplateMethod.Base.Units;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.TemplateMethod.Base.Attack
{
    public class RangeWeaponProjectile : MonoBehaviour
    {
        public void FlyToUnit(Unit unit, int damage)
        {
            StartCoroutine(FlyToUnityCoroutine(unit, damage));
        }

        private IEnumerator FlyToUnityCoroutine(Unit unit, int damage)
        {
            while (Vector3.Distance(transform.position, unit.transform.position) > 0.1f)
            {
                Quaternion targetLook = Quaternion.LookRotation(unit.transform.position - transform.position, Vector3.up);
                Quaternion rotateTowards = Quaternion.RotateTowards(transform.rotation, targetLook, 30f * Time.deltaTime);
                transform.rotation = rotateTowards;
                transform.position += (unit.transform.position - transform.position).normalized * 6 * Time.deltaTime;
                Debug.Log("Fly");
                yield return new WaitForEndOfFrame();
            }

            unit.ReceiveDamage(damage);
        }
    }
}