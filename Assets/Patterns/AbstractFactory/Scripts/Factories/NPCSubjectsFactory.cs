using Patterns.AbstractFactory.Enums;
using Patterns.AbstractFactory.Subjects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory.Factories
{
    public class NPCSubjectsFactory : SubjectFactory
    {
        public override Subject CreateWarrior(Vector3 position)
        {
            return Instantiate(_warriorSubjectPrefab, position, Quaternion.identity).SetOwner(Owner.NPC).SetColor(Color.red);
        }

        public override Subject CreateArcher(Vector3 position)
        {
            return Instantiate(_archerSubjectPrefab, position, Quaternion.identity).SetOwner(Owner.NPC).SetColor(Color.red);
        }
    }
}