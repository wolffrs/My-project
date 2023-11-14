using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CluePickManager : MonoBehaviour
{

    public CluePicker cluePicker;
    // Start is called before the first frame update
    void Start()
    {
       HidePanel();
        
    }

    public void ShowPanel()
    {
        cluePicker.ShowCluePanel();
    }

    public void HidePanel()
    {
        cluePicker.HideCluePanel();
    }




}
