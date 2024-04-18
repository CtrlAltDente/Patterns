using Patterns.Proxy.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Proxy.Unit
{
    public class Unit : MonoBehaviour, IMovable
    {
        public void Move(Vector3 moveDirection)
        {
            Debug.Log($"Move to: {moveDirection}");
        }
    }
}