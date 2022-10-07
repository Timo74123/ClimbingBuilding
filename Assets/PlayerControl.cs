using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Player
{
    public class PlayerControl : MonoBehaviour
    {
        [Header("Movement")]
        public float movementSpeed = 6f;
        private float verticalMovement;
        private float horizontalMovement;
        private Rigidbody2D rB;

        private void Start() => rB = GetComponent<Rigidbody2D>();

        private void Update()
        {
            verticalMovement = Input.GetAxisRaw("Vert");
            horizontalMovement = Input.GetAxisRaw("Horizontal");
        }

        private void FixedUpdate()
        {
            rB.velocity = new Vector3(verticalMovement * movementSpeed, rB.velocity.y);
            rB.velocity = new Vector2(horizontalMovement * movementSpeed, rB.velocity.y);
        }
    }
}
