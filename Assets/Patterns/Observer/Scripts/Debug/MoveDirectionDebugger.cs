using Patterns.Observer.Input;
using Patterns.Observer.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer.UI
{
    public class MoveDirectionDebugger : MonoBehaviour, IInputHandler
    {
        [SerializeField]
        private RectTransform _directionElement;

        [SerializeField]
        private float _positionMutiplier;

        public void SetInput(InputData inputData)
        {
            _directionElement.anchoredPosition = inputData.Move * _positionMutiplier;
        }
    }
}