using Patterns.FactoryMehod.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.FactoryMehod.Factories
{
    public class CubeFactory : IShapeFactory
    {
        public GameObject CreateShape()
        {
            return GameObject.CreatePrimitive(PrimitiveType.Cube);
        }
    }
}