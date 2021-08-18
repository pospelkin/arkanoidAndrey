using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.TryGetComponent<BallMove>(out BallMove Ball))
        {
            Destroy(Ball.gameObject);
            Debug.Log("Game Over");
        }
    }
}
