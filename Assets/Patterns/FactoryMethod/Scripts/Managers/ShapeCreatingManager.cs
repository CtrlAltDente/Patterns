using Patterns.FactoryMehod.Factories;
using Patterns.FactoryMehod.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.FactoryMehod.Managers
{
    public class ShapeCreatingManager : MonoBehaviour
    {
        //Note: This realization of IShapeFactory is wrong, because Unity is already have GameObject.CreatePrimitive that is Simple Factory
        //but I want only show and test how Factory Method pattern work.

        private IShapeFactory _shapeFactory;

        public void CreateCube()
        {
            CreateShape(PrimitiveType.Cube).transform.position = new Vector3(2, 1, 0);
        }

        public void CreateSphere()
        {
            CreateShape(PrimitiveType.Sphere).transform.position = new Vector3(-2, 1, 0);
        }

        public GameObject CreateShape(PrimitiveType type)
        {
            switch (type)
            {
                case PrimitiveType.Sphere:
                    {
                        _shapeFactory = new SphereFactory();
                        break;
                    }
                case PrimitiveType.Cube:
                    {
                        _shapeFactory = new CubeFactory();
                        break;
                    }
                default:
                    {
                        throw new Exception($"There is no realization for {type} shape type");
                    }
            }

            return _shapeFactory.CreateShape();
        }
    }
}