using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;


public class DialogueManager : MonoBehaviour
{
        public ColliderManager colliderManager;

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
            Debug.Log("A conversation has begun. Disabling Colliders");
            colliderManager.DisableGameColliders();
        }

        private void ConversationEnd()
        {
            Debug.Log("A conversation has ended. Enabling Colliders");
            colliderManager.EnableGameColliders(); 

            // if (ConversationManager.Instance.CurrentConversation) 
            // {
            //     cluePicker.ShowCluePanel();
            // }
        }
    }
