using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotebookScript : MonoBehaviour
{
    public TextMeshProUGUI clueTextLounge;
    public TextMeshProUGUI clueTextDiner;
    public TextMeshProUGUI clueTextGang;
    public TextMeshProUGUI clueTextSlaap;

    public void AddClueToText(string clue, TextMeshProUGUI targetClueText)
    {
        targetClueText.text = clue;
    }

    public string GetClueFromText(TextMeshProUGUI clueText)
    {
        return clueText.text;
    }

    public bool IsClueSelected(TextMeshProUGUI clueText)
    {
        // Check if the given clue text is not empty
        return !string.IsNullOrEmpty(clueText.text);
    }

}