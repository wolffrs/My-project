using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class LoungeConversation : MonoBehaviour
{
    public NPCConversation phaseOneConversation;
    public NPCConversation phaseTwoConversation;

    public bool read = false;

    public PhaseManager phaseManager;

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
            }
            else {
                Debug.Log("Go talk to the barman first");
            }
        }
    }
}
