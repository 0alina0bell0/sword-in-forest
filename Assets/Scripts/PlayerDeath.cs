using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    
    private bool hasEntered;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("DeadBox")&& !hasEntered)
        {
            Destroy(gameObject);
            LevelManager.instance.Respawn();
        }
    }
}
