using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TestPerson : MonoBehaviour
{
    public NPCConversation phaseOneConversation;
    public NPCConversation phaseTwoConversation;
    public Collider2D notebookCollider;

    public PhaseManager phaseManager;

    void Start()
    {
        notebookCollider.enabled = false;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            if (phaseManager.phaseOneActive) {
                ConversationManager.Instance.StartConversation(phaseOneConversation);
                //notebookCollider.enabled = true;
            } 
            if (phaseManager.phaseTwoActive && phaseManager.phaseInBetween) {
                ConversationManager.Instance.StartConversation(phaseTwoConversation);
                Debug.Log("Starting second conversation");
                phaseManager.phaseInBetween = false;
            }
        }
    }
}
