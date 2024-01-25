using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy.CameraSystem
{
    public class CameraPositionChanger : MonoBehaviour
    {
        [SerializeField]
        private CinemachineVirtualCamera _cinemachineVirtualCamera = default;

        public void SetActiveCamera()
        {
            _cinemachineVirtualCamera.enabled = false;
            _cinemachineVirtualCamera.enabled = true;
        }
    }
}