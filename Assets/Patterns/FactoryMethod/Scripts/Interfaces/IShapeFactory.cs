using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.FactoryMehod.Interfaces
{
    public interface IShapeFactory
    {
        public GameObject CreateShape();
    }
}