using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        //Блок 1 это белый блок с одной жизнью 
        //Блок 2 это красный блок с двумя жизнями
        //Блок 3 это синий блок с тремя жизнями

        if(collision.gameObject.tag == "Block3") {
            Destroy(collision.gameObject); // Уничтожаем блок 1
        }else if (collision.gameObject.tag == "Block2"){
             Destroy(collision.gameObject); // Заменяем блок 2 на блок 1
        }else if (collision.gameObject.tag == "Block1"){
             Destroy(collision.gameObject); // Заменяем блок 3 на блок 2
        }
    }
}
