using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseTwoShowClues : MonoBehaviour
{

    public GameObject vergrootGlas;
    public CluePickerNew cluePickerNew;
    // Start is called before the first frame update
    void Start()
    {
        vergrootGlas.SetActive(false);
    }

    public void ShowVergrootglas() 
    {
        vergrootGlas.SetActive(true);
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cluePickerNew.ShowCluePanel();

            // Add your custom logic here
        }
    }

}
