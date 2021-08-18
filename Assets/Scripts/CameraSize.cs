using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour
{
    private const float targetSizeX = 1920.0f;
    private const float targetSizeY = 1080.0f;
    private const float halfSize = 340.0f; //Половина высоты в пикселях

    private void Awake() {
        CameraResize();        
    }

    private void CameraResize()
    {
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float targetRatio = targetSizeX/targetSizeY;

        if (screenRatio >= targetRatio){
            Resize();
        }else{
            float differenSize = targetRatio/screenRatio;
            Resize(differenSize); 
        }
    }
    
    private void Resize (float differenSize = 1.0f){
        Camera.main.orthographicSize = targetSizeY/halfSize * differenSize;
    }
}
