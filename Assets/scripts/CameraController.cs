using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Camera mainCamera;

    public void PanToRoom(Transform targetLevel) 
    {
        mainCamera.transform.position = targetLevel.position;
    }

}
