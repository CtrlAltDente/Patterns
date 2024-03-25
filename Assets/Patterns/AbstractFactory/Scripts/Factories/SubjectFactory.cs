using Patterns.AbstractFactory.Subjects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory.Factories
{
    public abstract class SubjectFactory : MonoBehaviour
    {
        [SerializeField]
        protected Subject _warriorSubjectPrefab;
        [SerializeField]
        protected Subject _archerSubjectPrefab;

        public abstract Subject CreateWarrior(Vector3 position);
        public abstract Subject CreateArcher(Vector3 position);
    }
}