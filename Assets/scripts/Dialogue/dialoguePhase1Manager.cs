using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialoguePhase1Manager : MonoBehaviour
{
    public Button confirm;
    
    public LoungeConversation loungeConversation;
    public DinerConversation dinerConversation;
    public GangConversation gangConversation;
    public SlaapvertrekConversation slaapvertrekConversation;

    void Start()
    {
      //  confirm.gameObject.SetActive(false);
    }

    void Update()
    {
        if (loungeConversation.read && dinerConversation.read && gangConversation.read && slaapvertrekConversation.read) 
        {
            EverythingRead();
        }
    }

    public void EverythingRead()
    {
        confirm.gameObject.SetActive(true);
    }

}
