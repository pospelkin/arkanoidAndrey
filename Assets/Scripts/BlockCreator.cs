using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewInGame : MonoBehaviour
{
    public GameObject[] blockPrefabs;
    static int numberblockX = 15, numberblockY = 5;

    void CreatGamePole()
    {
        float Dx = 0.685f, dY = 0.5f;
        Vector3 MyPoze = new Vector3(-4.8f, 4, 0);

        for(int YY = 0; YY < numberblockY; YY++)
            {
                for (int XX = 0; XX < numberblockX; XX++)
                {
                    int blockIndex = Random.Range(0, blockPrefabs.Length);
                    Instantiate(blockPrefabs[blockIndex], MyPoze, Quaternion.identity);
                    //Получаем параметры блока
                    MyPoze.x +=Dx;
                }           
                //Начальная позиции линии по X
                MyPoze.x = -4.8f;
                //Новые координамы для Y
                MyPoze.y += dY;
            }
    }
    // Start is called before the first frame update
    void Start()
    {
        CreatGamePole();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
