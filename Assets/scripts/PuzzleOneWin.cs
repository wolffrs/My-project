using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleOneWin : MonoBehaviour
{

    [SerializeField] private GameObject Solved;

    public Button confirmPress;
    public Button nextPage;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;

    void Start()
    {
        confirmPress.onClick.AddListener(Confirmed);
        Solved.SetActive(false);
        nextPage.gameObject.SetActive(false);
    }


    public void Confirmed() {
        Debug.Log("checking");
        
        DraggableItem dragit1 = item1.GetComponent<DraggableItem>();
        DraggableItem dragit2 = item2.GetComponent<DraggableItem>();
        DraggableItem dragit3 = item3.GetComponent<DraggableItem>();

        if (dragit1.correct && dragit2.correct && dragit3.correct) {

            Debug.Log("You've solved the puzzle");

            Solved.SetActive(true);

            confirmPress.gameObject.SetActive(false);
            nextPage.gameObject.SetActive(true);

            dragit1.finished = true;
            dragit2.finished = true;
            dragit3.finished = true;
        
        }
        else {
            Debug.Log("This is not right");
        }
    }

}
