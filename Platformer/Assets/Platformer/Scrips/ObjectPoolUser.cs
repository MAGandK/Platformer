using System;
using PlayerSpasePlatformer;
using UnityEngine;
using UnityEngine.Serialization;

public class ObjectPoolUser : MonoBehaviour
 {
     [SerializeField] private Transform _shootingPoint;
     [SerializeField] private float _spawnInretval = 1.0f; // ностроить полеты шара
     private float _timer;
     [SerializeField]private Vector2 _shootingDirection;

     private void Update()
     {
         _timer += Time.deltaTime;
             _shootingDirection = _shootingPoint.right; 

         if (Input.GetMouseButtonDown(1) && _timer >= _spawnInretval)
         {
             _timer = 0f;
            SpawnObject();
         }
     }
     private void SpawnObject()
     {
         GameObject ball = Player.Instanse.GetPooledObject();
         if (ball != null)
         {
             Ball ballGet = ball.GetComponent<Ball>(); 
             if (ballGet != null)
             {
                 ball.transform.position = _shootingPoint.position;
                 ball.transform.rotation = _shootingPoint.rotation;
                 ball.SetActive(true);
                
                 ballGet.MovingBall(_shootingDirection); 
             }
         }
     }
}
