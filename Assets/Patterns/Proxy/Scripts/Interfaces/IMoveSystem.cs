using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Proxy.Interfaces
{
    public interface IMovable
    {
        public void Move(Vector3 moveDirection);
    }
}
