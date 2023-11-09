using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TestPerson : MonoBehaviour
{
    public NPCConversation myConversation;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            ConversationManager.Instance.StartConversation(myConversation);
        }
    }
}
