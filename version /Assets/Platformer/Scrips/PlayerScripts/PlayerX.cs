using System;
using UnityEngine;
using AnimationControll;

namespace PlayerSpase
{
    public class PlayerX : MonoBehaviour
    {
    
        [Header("Movement")]        
        [SerializeField] private float _speed = 1f;
        [SerializeField] private float _jumpForce = 1f;

        [Header("CillosionInfo")] 
        [SerializeField] private Transform _checkTransform;
        
        [SerializeField] private float _groundCheckRadius;
        [SerializeField] private LayerMask _groundLayerMask;
        internal bool _isGrounded;
        internal bool _isDoubleGround;
        
        private bool _isMoving;
        private float _velocityY;
        private bool _isFlip = true;
        
        private Rigidbody2D _rb;
        
        private MovementController _movementController;

        private AnimationController _animationController;
        
        private void Start()
        {
            _movementController = GetComponent<MovementController>();
            _animationController = GetComponent<AnimationController>();
            _rb = GetComponent<Rigidbody2D>(); 
        }


        private void Update()
        {
            _isMoving = _rb.velocity.x != 0;
            _velocityY = _rb.velocity.y;
            _animationController.Moving(_isMoving, _isGrounded, _velocityY);
   
            Flip();

            CollisionCheck();
        }
        private void FixedUpdate()
        {
            _rb.velocity = new Vector2( _movementController._moveInput * _speed, _rb.velocity.y);
        }
        
        internal void Jump()
        {
            if (_isGrounded)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, _jumpForce);
            }
            else if (_isDoubleGround)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, _jumpForce);
                _isDoubleGround = true;
            }
        }
        private void CollisionCheck()
        {
            _isGrounded = Physics2D.OverlapCircle(_checkTransform.position, _groundCheckRadius, _groundLayerMask);
        }
        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(_checkTransform.position, _groundCheckRadius);
        }

        private void Flip()
        {
            if (_rb.velocity.x > 0 && !_isFlip || _rb.velocity.x < 0 && _isFlip)
            {
                _isFlip = !_isFlip;
                transform.Rotate(0,180,0);
            }
        }
    }
}
