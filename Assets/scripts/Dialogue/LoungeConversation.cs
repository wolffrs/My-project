using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using TMPro;


public class LoungeConversation : MonoBehaviour
{
    public NPCConversation phaseOneConversation;
    public NPCConversation phaseTwoConversation;

    public bool read = false;
    //private bool 


    public PhaseManager phaseManager;
    public CluePickManager cluePickManager;
    public CluePicker cluePicker;

    void Start()
    {
        //cluePicker.firstClue.SetText("Werkt het?");
        Debug.Log("Starting Lounge Conversation");
    }


    private void OnEnable()
    {
        ConversationManager.OnConversationEnded += ConversationEnd;
    }

    private void OnDisable()
    {
        ConversationManager.OnConversationEnded -= ConversationEnd;
    }

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
                cluePicker.firstClue.SetText("Werkt het?");
            }
            else {
                Debug.Log("Go talk to the barman first");
            }
        }
    }

    private void ConversationEnd()
    {
        Debug.Log("Conversation ended");
        cluePickManager.ShowPanel();
    }
}
