using Patterns.SimpleFactory.BoostsExample.Enums;
using Patterns.SimpleFactory.BoostsExample.PlayerLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.BoostsExample.BoostsLogic
{
    [RequireComponent(typeof(Collider))]
    public abstract class Boost : MonoBehaviour
    {
        public abstract BoostType BoostType { get; }

        protected abstract void ApplyToPlayer(Player player);

        private void OnTriggerEnter(Collider other)
        {
            if(other.GetComponent<Player>() != null)
            {
                ApplyToPlayer(other.GetComponent<Player>());
                Destroy(gameObject);
            }
        }
    }
}