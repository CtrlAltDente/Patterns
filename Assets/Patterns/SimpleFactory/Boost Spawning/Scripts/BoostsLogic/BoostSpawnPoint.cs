using Patterns.SimpleFactory.BoostsExample.Enums;
using Patterns.SimpleFactory.BoostsExample.Factory;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.BoostsExample.BoostsLogic
{
    public class BoostSpawnPoint : MonoBehaviour
    {
        public BoostsFactory BoostsFactory;
        public BoostType BoostType;
        [Range(0,1)]
        public float Height = 0.5f;

        private void Start()
        {
            BoostsFactory.SpawnBoost(BoostType).transform.position = transform.position + new Vector3(0,Height,0);
        }
    }
}