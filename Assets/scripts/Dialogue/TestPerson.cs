using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TestPerson : MonoBehaviour
{
    public NPCConversation myConversation;
    public Collider2D notebookCollider;

    void Start()
    {
        notebookCollider.enabled = false;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            ConversationManager.Instance.StartConversation(myConversation);
            notebookCollider.enabled = true;
        }
    }
}
