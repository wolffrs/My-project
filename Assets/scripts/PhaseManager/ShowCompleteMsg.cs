using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCompleteMsg : MonoBehaviour
{
    public GameObject completedMessage;

    void Start()
    {
        completedMessage.gameObject.SetActive(false);
    }

    public void ShowMsg() 
    {
        completedMessage.gameObject.SetActive(true);
    }

    public void CloseMsg() 
    {
        completedMessage.gameObject.SetActive(false);
    }
}
