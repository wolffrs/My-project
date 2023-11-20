using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotebookFlip : MonoBehaviour
{
    // [SerializeField] private Button Next;
    // [SerializeField] private Button Previous;

    public int number = 1;

    [SerializeField] private GameObject page1;
    [SerializeField] private GameObject page2;
    [SerializeField] private GameObject page3;

    void Start() {

        page1.SetActive(true);
        page2.SetActive(false);
        page3.SetActive(false);
    }

    // void FlipToPage1() {
    //     Debug.Log("Flipping to first page");

    //     page1.SetActive(true);
    //     page2.SetActive(false);
    //     page3.SetActive(false);

    // }

    // void FlipToPage2() {
    //     Debug.Log("Flipping to second page");
        
    //     page1.SetActive(false);
    //     page2.SetActive(true);
    //     page3.SetActive(false);
        
    // }

    public void NextPage() {
        Debug.Log("Flipping to next page");
        number++;
        number = Mathf.Clamp(number, 1, 3);

        Flipping();
    }

    public void PreviousPage() {
        Debug.Log("Flipping to previous page");
        number--;
        number = Mathf.Clamp(number, 1, 3);

        Flipping();
    }

    public void Flipping() {
        Debug.Log("Flipping");

        if (number == 1) {
            Debug.Log("number is 1");
            page1.SetActive(true);
            page2.SetActive(false);
            page3.SetActive(false);
        }

         else if (number == 2) {
            Debug.Log("number is 2");
            page1.SetActive(false);
            page2.SetActive(true);
            page3.SetActive(false);
        }

        else if (number == 3) {
            Debug.Log("number is 3");
            page1.SetActive(false);
            page2.SetActive(false);
            page3.SetActive(true);
        }

        else {
            Debug.Log("Invalid page number");
            // page1.SetActive(true);
            // page2.SetActive(false);
            // page3.SetActive(false);  
        }

        
    }

}
