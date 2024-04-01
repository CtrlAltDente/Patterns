using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.CommandPattern.Commands;
using UnityEngine.UI;

namespace Patterns.CommandPattern.UI
{
    public class Cell : MonoBehaviour
    {
        [SerializeField]
        private Image _image;

        [SerializeField]
        private CommandOperator _commandOperator;

        public Command Command;

        private void Update()
        {
            CheckCooldown();
        }

        public void UseCommand()
        {
            _commandOperator.RaiseCommand(Command);
        }

        private void CheckCooldown()
        {
            if(Command.InCooldown)
            {
                _image.color = new Color(Color.red.r, Color.red.g, Color.red.b, 0.5f);
            }
            else
            {
                _image.color = Color.white;
            }
        }
    }
}