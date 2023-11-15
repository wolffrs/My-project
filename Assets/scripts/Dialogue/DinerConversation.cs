using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;


public class DinerConversation : MonoBehaviour
{
    public NPCConversation phaseOneConversation;
    public NPCConversation phaseTwoConversation;
    public bool read = false;

    public PhaseManager phaseManager;
    public CluePicker cluePicker;


    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (phaseManager.phaseOneActive) {
                ConversationManager.Instance.StartConversation(phaseOneConversation);
                read = true;
            } 
            if (phaseManager.phaseTwoActive && !phaseManager.phaseInBetween) {
                ConversationManager.Instance.StartConversation(phaseTwoConversation);
                cluePicker.firstClue.SetText("Diner Clue 1");
                cluePicker.secondClue.SetText("Diner Clue 2");
                cluePicker.thirdClue.SetText("Diner Clue 3");
            }
            else {
                Debug.Log("Go talk to the barman first");
            }
        }
    }
}

