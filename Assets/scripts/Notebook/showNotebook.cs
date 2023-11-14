using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class showNotebook : MonoBehaviour
{
    [SerializeField] private GameObject Notebook;
    [SerializeField] private GameObject Background;
    public Collider2D[] gameColliders;

    void Start() {
        gameObject.GetComponent<Button>().onClick.AddListener(ShowAndHide);
        Notebook.SetActive(false);
        Background.SetActive(false);
    }

    private void ShowAndHide() {

        Notebook.SetActive(!Notebook.activeSelf);
        Background.SetActive(!Background.activeSelf);

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
