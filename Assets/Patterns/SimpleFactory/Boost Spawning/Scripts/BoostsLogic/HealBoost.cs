using Patterns.SimpleFactory.BoostsExample.Enums;
using Patterns.SimpleFactory.BoostsExample.PlayerLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.BoostsExample.BoostsLogic
{
    public class HealBoost : Boost
    {
        public override BoostType BoostType => BoostType.Heal;

        protected override void ApplyToPlayer(Player player)
        {
            Debug.Log("Applied boost Heal to Player");
        }
    }
}