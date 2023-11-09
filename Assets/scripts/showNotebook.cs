using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class showNotebook : MonoBehaviour
{
    [SerializeField] private GameObject Notebook;
    public Collider2D[] gameColliders;

    void Start() {
        gameObject.GetComponent<Button>().onClick.AddListener(ShowAndHide);
        Notebook.SetActive(false);
    }

    private void ShowAndHide() {

        // if(gameObject.activeSelf)
        // {
        // Notebook.SetActive(!Notebook.activeSelf);
        // }
        
        // if(gameObject.activeSelf == true) 
        // {
        //     DisableGameColliders();
        // }
        // if(gameObject.activeSelf == false) {
        //     EnableGameColliders();
        // }

        Notebook.SetActive(!Notebook.activeSelf);

        if (Notebook.activeSelf)
        {
            DisableGameColliders();
        }
        else
        {
            EnableGameColliders();
        }
    }

    void DisableGameColliders()
    {
        foreach (Collider2D collider in gameColliders)
        {
            collider.enabled = false;
        }
    }

    void EnableGameColliders()
    {
        foreach (Collider2D collider in gameColliders)
        {
            collider.enabled = true;
        }
    }

}
