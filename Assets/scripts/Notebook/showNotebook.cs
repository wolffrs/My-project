using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class showNotebook : MonoBehaviour
{
    [SerializeField] private GameObject Notebook;
    [SerializeField] private GameObject Background;

    public GameObject gameParent;
  //  public Collider2D[] gameColliders;

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

    public void DisableGameColliders()
    {
        // foreach (Collider2D collider in gameColliders)
        // {
        //     collider.enabled = false;
        // }
        Debug.Log("Collider disabled");
        foreach (var c in gameParent.GetComponentsInChildren<Collider2D>())
        {
            c.enabled = false;
        }
    }

    public void EnableGameColliders()
    {
        // foreach (Collider2D collider in gameColliders)
        // {
        //     collider.enabled = true;
        // }

        Debug.Log("Collider enabled");
        foreach(var c in gameParent.GetComponentsInChildren<Collider2D>())
        {
            c.enabled = true;
        }
    }

}
