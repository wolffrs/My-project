using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleOneWin : MonoBehaviour
{

    [SerializeField] private GameObject Solved;

    public Button confirmPress;
    public Button nextPage;
    public Button verder;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;

    public PhaseManager phaseManager;
    public ShowCompleteMsg showCompleteMsg;

    void Start()
    {
        confirmPress.onClick.AddListener(Confirmed);
        verder.onClick.AddListener(Continue);

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

            StartCoroutine(StartPhaseTwo());
        
        }
        else {
            Debug.Log("This is not right");
        }
    }

    public void Continue() 
    {
        showCompleteMsg.CloseMsg();


    }

    IEnumerator StartPhaseTwo()
    {
        yield return new WaitForSeconds(1);
        showCompleteMsg.ShowMsg();
        
        phaseManager.phaseOneActive = false;
        phaseManager.phaseTwoActive = true;
        phaseManager.phaseInBetween = true;
    }

}
