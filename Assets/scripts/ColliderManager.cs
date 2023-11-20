using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    public GameObject gameParent;

    public void DisableGameColliders()
    {
        Debug.Log("Collider disabled");
        foreach (var c in gameParent.GetComponentsInChildren<Collider2D>())
        {
            c.enabled = false;
            //Debug.Log("Disabled Collider: " + c.gameObject.name);
        }
    }

    public void EnableGameColliders()
    {
        Debug.Log("Collider enabled");
        foreach(var c in gameParent.GetComponentsInChildren<Collider2D>())
        {
            c.enabled = true;
        }
    }
}
