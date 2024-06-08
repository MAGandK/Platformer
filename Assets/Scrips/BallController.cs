using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolController : MonoBehaviour
{
    public delegate void Destroyed();
    public static event Destroyed OnBallDestroyed;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            OnBallDestroyed?.Invoke();
            ShootingPlayer.ReturnObjectToPool(gameObject);
            Debug.Log("Удар с Enemy");
            
        }
        else if (other.gameObject.tag == "Level")
        {
            OnBallDestroyed?.Invoke();
            ShootingPlayer.ReturnObjectToPool(gameObject);
            Debug.Log("Удар с уровнем");
        }
    }
}
