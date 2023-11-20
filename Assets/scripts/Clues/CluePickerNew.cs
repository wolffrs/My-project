using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CluePickerNew : MonoBehaviour
{
    public GameObject cluePanel;
    public Button[] clueButtons;
    public NotebookScript notebookScript;
    public ColliderManager colliderManager;

    [Header("Clue Texts")]
    public TextMeshProUGUI firstClue;
    public TextMeshProUGUI secondClue;
    public TextMeshProUGUI thirdClue;

    public TextMeshProUGUI targetClueText;

    void Start()
    {
        // cluePanel.SetActive(false);
        //HideCluePanel();
        cluePanel.SetActive(false);


        for (int i = 0; i < clueButtons.Length; i++)
        {
            int clueIndex = i;
            clueButtons[i].onClick.AddListener(() => OnClueButtonClick(clueIndex));
        }
    }

    public void ShowCluePanel()
    {
        cluePanel.SetActive(true);

        colliderManager.DisableGameColliders();
        Debug.Log("Showing clue panel. Disabling colliders");
        
        
    }

    public void HideCluePanel()
    {
        cluePanel.SetActive(false);

        colliderManager.EnableGameColliders();
        Debug.Log("Hiding clue panel. Enabling colliders");

    }

    // void OnClueButtonClick(int clueIndex)
    // {
    //     string selectedClue = GetClueFromIndex(clueIndex);
    //     notebookScript.AddClue(selectedClue);
    //     HideCluePanel();
    // }

    void OnClueButtonClick(int clueIndex)
    {
        string selectedClue = GetClueFromIndex(clueIndex);

        // Add the clue to the specified target clue text
        notebookScript.AddClueToText(selectedClue, targetClueText);

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