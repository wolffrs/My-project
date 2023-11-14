using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotebookScript : MonoBehaviour
{
    public TextMeshProUGUI clueText; // Reference to the Text component displaying clues

    public void AddClue(string clue)
    {
        // Append the new clue to the existing text
        clueText.text += "\n" + clue;
    }
}