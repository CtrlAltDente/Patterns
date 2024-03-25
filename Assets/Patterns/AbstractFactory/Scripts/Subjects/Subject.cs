using Patterns.AbstractFactory.Enums;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Patterns.AbstractFactory.Subjects
{
    public abstract class Subject : MonoBehaviour
    {
        [SerializeField]
        private Renderer _renderer;
        [SerializeField]
        private Material _material;

        public Owner Owner { get; private set; }
        public int Health { get; protected set; }

        private void Awake()
        {
            SetupMaterials();
        }

        public abstract void Attack();

        public Subject SetOwner(Owner owner)
        {
            Owner = owner;
            return this;
        }

        public Subject SetColor(Color color)
        {
            _material.color = color;
            return this;
        }

        private void SetupMaterials()
        {
            _renderer.material = new Material(_material);
            _material = _renderer.material;
        }
    }
}