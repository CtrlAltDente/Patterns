using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.BoostsExample.PlayerLogic
{
    public class Player : MonoBehaviour
    {
        private void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector3 moveVector = (Input.GetAxis("Horizontal") * Vector3.right) + (Input.GetAxis("Vertical") * Vector3.forward);
            transform.position += moveVector * 2 * Time.deltaTime;
        }
    }
}