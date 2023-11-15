using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;


public class DialogueManager : MonoBehaviour
{
        public showNotebook shownotebook;
        public CluePickManager cluePickManager;
        public Collider2D theNotebook;

        private void OnEnable()
        {
            ConversationManager.OnConversationStarted += ConversationStart;
            ConversationManager.OnConversationEnded += ConversationEnd;
        }

        private void OnDisable()
        {
            ConversationManager.OnConversationStarted -= ConversationStart;
            ConversationManager.OnConversationEnded -= ConversationEnd;
        }

        private void ConversationStart()
        {
            Debug.Log("A conversation has began.");
            shownotebook.DisableGameColliders();
            theNotebook.enabled = false;
        }

        private void ConversationEnd()
        {
            Debug.Log("A conversation has ended.");
            shownotebook.EnableGameColliders();
            theNotebook.enabled = true;

            // if (clueConvoHad == true) 
            // {
                cluePickManager.ShowPanel();
            //}
        }
    }
