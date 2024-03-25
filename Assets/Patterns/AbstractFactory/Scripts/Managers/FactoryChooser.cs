using Patterns.AbstractFactory.Factories;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory.Managers
{
    public class FactoryChooser : MonoBehaviour
    {
        [SerializeField]
        private NPCSubjectsFactory _npcSubjectsFactory;
        [SerializeField]
        private PlayerSubjectsFactory _playerSubjectsFactory;

        [SerializeField]
        private FactoryManager _factoryManager;

        public void SetupNpcFactory()
        {
            _factoryManager.SetSubjectFactory(_npcSubjectsFactory);
        }

        public void SetupPlayerFactory()
        {
            _factoryManager.SetSubjectFactory(_playerSubjectsFactory);
        }
    }
}