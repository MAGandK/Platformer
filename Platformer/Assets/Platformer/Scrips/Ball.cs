using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSpasePlatformer;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rbBall;
    
    [SerializeField] private float _ballSpeed = 10f;
    private Vector3 _direction;

    private void Awake()
    {
        _rbBall = GetComponent<Rigidbody2D>();
    }
    
    public void MovingBall(Vector2 direction)
    {
        _rbBall.velocity = direction * _ballSpeed;
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        // if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Level"))
        // {
            Player.Instanse.ReturnObjectToPool(this.gameObject);
       // }
    }
   
}
