using Patterns.AbstractFactory.Factories;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Patterns.AbstractFactory.Managers
{
    public class FactoryManager : MonoBehaviour
    {
        [SerializeField]
        private SubjectFactory _subjectFactory;

        [SerializeField]
        private TMP_InputField _xPos;
        [SerializeField]
        private TMP_InputField _yPos;

        public void SetSubjectFactory(SubjectFactory subjectFactory)
        {
            _subjectFactory = subjectFactory;
        }

        public void CreateWarrior()
        {
            Vector3 position = new Vector3(float.Parse(_xPos.text), 0, float.Parse(_yPos.text));
            _subjectFactory.CreateWarrior(position);
        }

        public void CreateArcher()
        {
            Vector3 position = new Vector3(float.Parse(_xPos.text), 0, float.Parse(_yPos.text));
            _subjectFactory.CreateArcher(position);
        }
    }
}