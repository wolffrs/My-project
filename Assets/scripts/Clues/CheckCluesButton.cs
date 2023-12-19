using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCluesButton : MonoBehaviour
{
    public NotebookScript notebookScript;
    public ShowIncorrectClues showIncorrectClues;
    public ShowCompleteMsg showCompleteMsg;

    public Button goPageThree;
    public Button giveTip;
    public Button clueCheck;

    private float littleWait = 0.3f;
    
    void Start() 
    {
        goPageThree.gameObject.SetActive(false);
        giveTip.gameObject.SetActive(false);
        clueCheck.gameObject.SetActive(false);
    }

    public void OnButtonClick()
    {
        // Assuming the clues are logged in the order Lounge, Diner, Gang, Slaap
        string loungeClue = notebookScript.GetClueFromText(notebookScript.clueTextLounge);
        string dinerClue = notebookScript.GetClueFromText(notebookScript.clueTextDiner);
        string gangClue = notebookScript.GetClueFromText(notebookScript.clueTextGang);
        string slaapClue = notebookScript.GetClueFromText(notebookScript.clueTextSlaap);

        // Check if the clues are correct
        if (loungeClue == "Dominik. De journalist. Altijd aan het schrijven in zijn notitieboekje. Volgens mij is hij het met ons eens over hoeden." && dinerClue == "Mes. Ik zag een bebloede mes in de keuken toen ik koffiebonen ging halen. Maar dat hoort, toch?" && gangClue == "Ik hoorde vanochtend ruzie. Misschien hadden het slachtoffer en de dader een mening verschil?" && slaapClue == "Sarah, de hondenfan. We waren aan het kaarten, en rond de tijd van de moord ging ze plassen, maar ze was láng weg.")
        {
            Debug.Log("All clues are correct!");
            goPageThree.gameObject.SetActive(true);
            showIncorrectClues.HideIncorrect();
            StartCoroutine(StartPhaseThree());
        }
        else
        {
            Debug.Log("Incorrect clues. Keep investigating!");
            giveTip.gameObject.SetActive(true);
        }
    }

    public void CheckButtonAvailability()
    {
        Debug.Log("Checking button availability...");

        // Enable the "Check Clues" button only if all four clues have been selected
        bool isLoungeSelected = notebookScript.IsClueSelected(notebookScript.clueTextLounge);
        bool isDinerSelected = notebookScript.IsClueSelected(notebookScript.clueTextDiner);
        bool isGangSelected = notebookScript.IsClueSelected(notebookScript.clueTextGang);
        bool isSlaapSelected = notebookScript.IsClueSelected(notebookScript.clueTextSlaap);

        Debug.Log($"Lounge: {isLoungeSelected}, Diner: {isDinerSelected}, Gang: {isGangSelected}, Slaap: {isSlaapSelected}");

        if (isLoungeSelected && isDinerSelected && isGangSelected && isSlaapSelected)
        {
            clueCheck.gameObject.SetActive(true);
        }
        else
        {
            clueCheck.gameObject.SetActive(false);
        }
    }

    IEnumerator StartPhaseThree()
    {
        Debug.Log("Starting Phase Thjree");
        yield return new WaitForSeconds(littleWait);
        showCompleteMsg.ShowMsgTwo();
        
    }
    
    
}