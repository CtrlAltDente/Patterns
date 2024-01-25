using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Patterns.Strategy.GameHandlers
{
    public class ZoneHandler : MonoBehaviour
    {
        public List<GameObjectTagEvent> GameObjectEnterEvents;
        public List<GameObjectTagEvent> GameObjectExitEvents;

        private void OnTriggerEnter(Collider other)
        {
            HandleEvents(GameObjectEnterEvents, other);
        }

        private void OnTriggerExit(Collider other)
        {
            HandleEvents(GameObjectExitEvents, other);
        }

        private void HandleEvents(List<GameObjectTagEvent> gameObjectTagEvents, Collider collider)
        {
            foreach (GameObjectTagEvent enterEvent in gameObjectTagEvents)
            {
                if (enterEvent.Tag == collider.tag)
                {
                    enterEvent.Event?.Invoke(collider);
                }
            }
        }
    }
}