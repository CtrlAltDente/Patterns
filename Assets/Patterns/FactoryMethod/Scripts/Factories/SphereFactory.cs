using Patterns.FactoryMehod.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.FactoryMehod.Factories
{
    public class SphereFactory : IShapeFactory
    {
        public GameObject CreateShape()
        {
            return GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }
    }
}