using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCollider : MonoBehaviour
{
    public Canvas menuCanvas;
    public Collider2D[] gameColliders;

    void Start()
    {
        // Disable game button colliders initially
        
    }

    public void OpenMenu()
    {
        // Enable menu canvas
        menuCanvas.enabled = true;

        // Disable game button colliders
        DisableGameColliders();
    }

    public void CloseMenu()
    {
        // Disable menu canvas
        menuCanvas.enabled = false;

        // Enable game button colliders
        EnableGameColliders();
    }

    void DisableGameColliders()
    {
        foreach (Collider2D collider in gameColliders)
        {
            collider.enabled = false;
        }
    }

    void EnableGameColliders() {
        foreach (Collider2D collider in gameColliders)
        {
            collider.enabled = true;
        }
    }
}
