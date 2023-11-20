using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCompleteMsg : MonoBehaviour
{
    public GameObject completedMessage;
    public GameObject completedMessageTwo;

    void Start()
    {
        completedMessage.gameObject.SetActive(false);
        completedMessageTwo.gameObject.SetActive(false);
    }

//PHASE ONE COMPLETE
    public void ShowMsg() 
    {
        completedMessage.gameObject.SetActive(true);
    }

    public void CloseMsg() 
    {
        completedMessage.gameObject.SetActive(false);
    }

//PHASE TWO COMPLETE
    public void ShowMsgTwo()
    {
        completedMessageTwo.gameObject.SetActive(true);
    }

    public void CloseMsgTwo()
    {
        completedMessageTwo.gameObject.SetActive(false);
    }
}
