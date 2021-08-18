using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float movingSpeed = 10f;
    public float xRange = 4.1f;

    public static PlayerController instance;

    // Управление платформой, при помощи клавишь (для проверки)
    void FixedUpdate()
    {
        if(transform.position.x < -xRange) {
            transform.position = new Vector3 (-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange) {
            transform.position = new Vector3 (xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * movingSpeed * Time.deltaTime);
    }

    public void Kill()
    { 
        GameManager.instance.GameOver();  
    }

    public void StartGame() { 
    //animator.SetBool("isAlive", true); 
    //this.transform.position = startingPosition; 
  } 

}
