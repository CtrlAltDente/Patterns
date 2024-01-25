using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Patterns.Strategy.GameHandlers
{
    [Serializable]
    public struct GameObjectTagEvent
    {
        public string Tag;
        public UnityEvent<Collider> Event;  
    }
}