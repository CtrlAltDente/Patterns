using Patterns.SimpleFactory.BoostsExample.BoostsLogic;
using Patterns.SimpleFactory.BoostsExample.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.BoostsExample.Factory
{
    [CreateAssetMenu(fileName = "BoostsFactory", menuName = "ScriptableObjects/Patterns/Simple Factory/BoostsFactory", order = 0)]
    public class BoostsFactory : ScriptableObject
    {
        [SerializeField]
        private Boost[] Boosts;

        public Boost SpawnBoost(BoostType boostType)
        {
            return Instantiate(GetBoostByType(boostType));
        }

        private Boost GetBoostByType(BoostType boostType)
        {
            foreach(Boost boost in Boosts)
            {
                if(boost.BoostType == boostType)
                    return boost;
            }

            throw new Exception($"There is no boost with {boostType} type");
        }
    }
}