using System;
using UnityEngine;

namespace PlayerSpasePlatformer
{ 
    public class MovementController : MonoBehaviour
    {
        internal float _moveInput;
        private Player _player;

        private void Start()
        {
            _player = GetComponent<Player>();
        }

        private void Update()
        {
             _moveInput = Input.GetAxis("Horizontal");
             if (Input.GetKey(KeyCode.Space))
             {
                 _player.Jump();
             }
             if (_player._isGrounded)
             {
                 _player._isDoubleGround = true;
             }
        }
    }
}
