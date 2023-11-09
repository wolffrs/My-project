using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowButton : MonoBehaviour 
{
    public ControlCamera controlCamera;
    //public GameObject arrowObject;
    public SpriteRenderer spriteRenderer;

    private bool isFlipped = false;
    private static bool isOnCooldown = false;

    void OnMouseDown() {

        if (!isOnCooldown) {
            if (!isFlipped)
            {
                controlCamera.PanToNextLevel();
            }
            else
            {
                controlCamera.PanToPreviousLevel();
            }
            FlipArrow();
            StartCoroutine(Cooldown());

        }
    }

    void FlipArrow()
    {
        spriteRenderer.flipX = !isFlipped;
        isFlipped = !isFlipped;
    }

    private IEnumerator Cooldown()
    {
        isOnCooldown = true;
        yield return new WaitForSeconds(1f);
        isOnCooldown = false;
    }

}
