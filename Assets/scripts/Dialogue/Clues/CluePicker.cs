using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CluePicker : MonoBehaviour
{
    public GameObject cluePanel;
    public Button[] clueButtons;
    public NotebookScript notebookScript;
    public showNotebook shownotebook;

    public TextMeshProUGUI firstClue;
    public TextMeshProUGUI secondClue;
    public TextMeshProUGUI thirdClue;

    private bool panelActive = false;

    void Start()
    {
        // cluePanel.SetActive(false);

        for (int i = 0; i < clueButtons.Length; i++)
        {
            int clueIndex = i;
            clueButtons[i].onClick.AddListener(() => OnClueButtonClick(clueIndex));
        }
    }

    // void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         if (panelActive)
    //             HideCluePanel();
    //         else
    //             ShowCluePanel();
    //     }
    // }

    public void ShowCluePanel()
    {
        cluePanel.SetActive(true);
        panelActive = true;

        if (panelActive == true)
        {
            shownotebook.DisableGameColliders();
        }
        
    }

    public void HideCluePanel()
    {
        cluePanel.SetActive(false);
        panelActive = false;
        shownotebook.EnableGameColliders();
    }

    void OnClueButtonClick(int clueIndex)
    {
        string selectedClue = GetClueFromIndex(clueIndex);
        notebookScript.AddClue(selectedClue);
        HideCluePanel();
    }

    string GetClueFromIndex(int index)
    {
        // Customize this based on your specific scenario
        switch (index)
        {
            case 0:
                return firstClue.text;
            case 1:
                return secondClue.text;
            case 2:
                return thirdClue.text;
            default:
                return "Error";
        }
    }
}