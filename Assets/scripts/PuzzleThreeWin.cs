using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleThreeWin : MonoBehaviour
{

    [SerializeField] private GameObject Solved;

    public Button confirmPress;
    public Button verder;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;

    public PhaseManager phaseManager;
    public ShowCompleteMsg showCompleteMsg;
    private float waitLittle = 0.3f;

    void Start()
    {
        confirmPress.onClick.AddListener(Confirmed);

        Solved.SetActive(false);
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

            dragit1.finished = true;
            dragit2.finished = true;
            dragit3.finished = true;

            StartCoroutine(RestartGame());
        
        }
        else {
            Debug.Log("This is not right");
        }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(waitLittle);
        showCompleteMsg.ShowMsgThree();
    
    }

}
