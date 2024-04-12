using Patterns.StatePattern.StateLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Patterns.StatePattern.UnitLogic
{
    public class Unit : MonoBehaviour
    {
        [SerializeField]
        private NavMeshAgent _navMeshAgent;

        [SerializeField]
        private bool _isSelected;

        [SerializeField]
        private Color _selectedColor;

        [SerializeField]
        private Color _unselectedColor;

        private State _state;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                foreach(Renderer renderer in GetComponentsInChildren<Renderer>())
                {
                    renderer.material.color = _isSelected ? _selectedColor : _unselectedColor;
                }
            }
        }

        public void MoveTo(Vector3 position)
        {
            _navMeshAgent.SetDestination(position);
        }
    }
}