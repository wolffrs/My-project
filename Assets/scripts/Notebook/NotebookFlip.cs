using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotebookFlip : MonoBehaviour
{
    [SerializeField] private Button Next;
    [SerializeField] private Button Previous;

    [SerializeField] private GameObject page1;
    [SerializeField] private GameObject page2;

    void Start() {
        Next.onClick.AddListener(FlipToPage2);
        Previous.onClick.AddListener(FlipToPage1);

        page2.SetActive(false);
    }

    void FlipToPage1() {
        Debug.Log("Flipping to first page");

        page1.SetActive(true);
        page2.SetActive(false);

    }

    void FlipToPage2() {
        Debug.Log("Flipping to second page");
        
        page1.SetActive(false);
        page2.SetActive(true);
        
    }

}
