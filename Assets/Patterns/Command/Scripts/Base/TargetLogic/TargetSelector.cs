using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.CommandPattern.Base.TargetLogic
{
    public class TargetSelector : MonoBehaviour
    {
        public ITarget SelectedTarget { get; private set; }

        public void SelectTarget()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var target))
            {
                if(target.collider.GetComponent<ITarget>() != null)
                {
                    SelectedTarget = target.collider.GetComponent<ITarget>();
                    Debug.Log("target selected!");
                }
            }
        }
    }
}