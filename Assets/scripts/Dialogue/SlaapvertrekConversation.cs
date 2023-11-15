using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;


public class SlaapvertrekConversation : MonoBehaviour
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
                cluePicker.firstClue.SetText("Slaapvertrek Clue 1");
                cluePicker.secondClue.SetText("Slaapvertrek Clue 2");
                cluePicker.thirdClue.SetText("Slaapvertrek Clue 3");
            }
            // else {
            //     Debug.Log("Go talk to the barman first");
            // }
        }
    }
}

