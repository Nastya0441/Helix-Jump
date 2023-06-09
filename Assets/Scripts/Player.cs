using System;
using UnityEngine;



public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Game Game;
 

    public Platforms CurrentPlatform;

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0,BounceSpeed,0);
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
        
    }

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
        
    }
}
