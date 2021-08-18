using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private bool _isActive;
    private const float Force = 300f;
    private const float OffsetX = 100f; 

    public static BallMove instance;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.bodyType = RigidbodyType2D.Kinematic;    
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space) && !_isActive)
        {
            BallActive();
        }

        if(Input.touchCount > 0 && !_isActive){
            Touch touch = Input.GetTouch(0);
            if(touch.tapCount > 1)
            {
                BallActive();
            }
        }
    }
    private void BallActive(){
        _isActive = true;
        transform.SetParent(null);
        _rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
        _rigidbody2D.AddForce(new Vector2(OffsetX, Force));
    }
}
