using Patterns.Observer.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer.Interfaces
{
    public interface IInputHandler
    {
        public void SetInput(InputData inputData);
    }
}