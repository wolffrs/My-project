using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNotebookAndArrow : MonoBehaviour
{
    public GameObject[] gameObjects;

    void Start() 
    {
        ObjectsDisabled();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            ObjectsEnabled();

        }
    }

    private void ObjectsDisabled()
    {
        foreach (GameObject gameObject in gameObjects)
        {
            gameObject.SetActive(false);
        }
    }

    private void ObjectsEnabled()
    {
        foreach (GameObject gameObject in gameObjects)
        {
            gameObject.SetActive(true);
        }
    }

}
