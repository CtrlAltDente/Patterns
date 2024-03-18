using Patterns.SimpleFactory.BoostsExample.Enums;
using Patterns.SimpleFactory.BoostsExample.PlayerLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.BoostsExample.BoostsLogic
{
    public class SpeedUpBoost : Boost
    {
        public override BoostType BoostType => BoostType.SpeedUp;

        protected override void ApplyToPlayer(Player player)
        {
            Debug.Log("Applied boost Speed Up to Player");
        }
    }
}
