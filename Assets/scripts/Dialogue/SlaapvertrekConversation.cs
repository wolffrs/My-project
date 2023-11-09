using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;


public class SlaapvertrekConversation : MonoBehaviour
{
  public NPCConversation phaseOneConversation;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ConversationManager.Instance.StartConversation(phaseOneConversation);
        }
    }
}

