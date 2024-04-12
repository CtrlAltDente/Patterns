using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.StatePattern.StateLogic
{
    public class StateSelector : MonoBehaviour
    {
        [SerializeField]
        private State[] _states;

        public State CurrentState { get; private set; }

        private void Start()
        {
            CurrentState = _states[0];
        }

        private void Update()
        {
            KeyToState();
        }

        public void SelectState(int state)
        {
            CurrentState = _states[state];
        }

        private void KeyToState()
        {
            if(Input.GetKeyDown(KeyCode.F1))
            {
                CurrentState = _states[0];
            }
            if(Input.GetKeyDown(KeyCode.F2))
            {
                CurrentState = _states[1];
            }
        }
    }
}