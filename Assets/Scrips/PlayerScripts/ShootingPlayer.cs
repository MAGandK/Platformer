using System;
using System.Collections;
using System.Collections.Generic;
using PlayerSpasePlatformer;
using UnityEngine;
using UnityEngine.Serialization;

public class ShootingPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    [SerializeField] private int _initialSize = 15;
    [SerializeField] private Transform _shootingPoint;
    [SerializeField] private float _spawnInterval = 1.0f; 
    
    private List<GameObject> _ballsPool;
    
    private float _timer;

    private void Start()
    {
        PoolBalls();
    }
    private void Update()
    {
        _timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && _timer >= _spawnInterval)
        {
            _timer = 0f;
            SpawnObject();
        }
    }

    private void PoolBalls()
    {
        _ballsPool = new List<GameObject>();
        for (int i = 0; i < _initialSize; i++)
        {
            GameObject newBallPool = Instantiate(_ball);
            newBallPool.SetActive(false);
            _ballsPool.Add(newBallPool);
        }
    }
    public GameObject GetPooledObject()
    {
        foreach (var ball in _ballsPool)
        {
            if (!ball.activeInHierarchy)
            {
                return ball;
            }
        }
        
        GameObject newBall = Instantiate(_ball);
        newBall.SetActive(false);
        _ballsPool.Add(newBall);
        return newBall;
    }
        

    private void SpawnObject()
    { 
        GameObject ball = GetPooledObject();
        if (ball != null)
        {
            ball.transform.position = _shootingPoint.transform.position;
            ball.transform.rotation = _shootingPoint.transform.rotation;
            ball.SetActive(true);
        }
    }
    internal static void ReturnObjectToPool(GameObject obj)
    {
        obj.SetActive(false);
    }
}
