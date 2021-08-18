using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UISwipeHandler : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public Transform player;
    public float speed = 10f;
        

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 delta = eventData.delta; // Локальная переменная крайних коодинат перемещения пальца
        float moveHorizontal = Input.GetAxis("Horizontal");
        
        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y)){ // Проверка направления перемещения по осям X, Y 
            if(delta.x > 0) //Направление влево или в право 
            {
                Debug.Log("right");
                Vector3 position = player.position;
                position.x += 1.5f; 
                player.position = position;
            }
            else
            {
                Debug.Log("left");
                Vector3 position = player.position;
                position.x -= 1.5f;
                player.position = position;
            }
                
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        
    }
}
