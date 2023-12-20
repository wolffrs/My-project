using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowCompleteMsg : MonoBehaviour
{
    public GameObject completedMessage;
    public GameObject completedMessageTwo;
    public GameObject completedMessageThree;

    void Start()
    {
        completedMessage.gameObject.SetActive(false);
        completedMessageTwo.gameObject.SetActive(false);
        completedMessageThree.gameObject.SetActive(false);
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

//PHASE TWO COMPLETE
    public void ShowMsgThree()
    {
        completedMessageThree.gameObject.SetActive(true);
    }

    public void Restart()
    {
       SceneManager.LoadScene("SampleScene");
    }
}
