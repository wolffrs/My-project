using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowIncorrectClues : MonoBehaviour
{
    public NotebookScript notebookScript;
    public TextMeshProUGUI incorrectCluesText;

    public void ShowIncorrect()
    {
        string incorrectClues = GetIncorrectClues();
        incorrectCluesText.text = "Incorrect Clues:\n" + incorrectClues;
    }

    public void HideIncorrect()
    {
        incorrectCluesText.text = ""; // Set the text to an empty string
        // Alternatively, you can disable the whole gameObject if you want to hide the entire object
        // gameObject.SetActive(false);
    }

    private string GetIncorrectClues()
    {
        // Replace "CorrectClue", "SecondCorrectClue", "ThirdCorrectClue" with the actual correct clues for each case
        string correctClueLounge = "Correct Lounge";
        string correctClueDiner = "Correct Diner";
        string correctClueGang = "Correct Gang";
        string correctClueSlaap = "Correct Slaap";

        string incorrectClues = "";

        // Compare the selected clues with the correct clues for each case
        if (notebookScript.GetClueFromText(notebookScript.clueTextLounge) != correctClueLounge)
        {
            incorrectClues += "De gekozen clue in de lounge is niet juist.";
        }

        if (notebookScript.GetClueFromText(notebookScript.clueTextDiner) != correctClueDiner)
        {
            incorrectClues += "De gekozen clue in de diner is niet juist.";
        }

        if (notebookScript.GetClueFromText(notebookScript.clueTextGang) != correctClueGang)
        {
            incorrectClues += "De gekozen clue in de gang is niet juist.";
        }

        if (notebookScript.GetClueFromText(notebookScript.clueTextSlaap) != correctClueSlaap)
        {
            incorrectClues += "De gekozen clue in het slaapvertrek is niet juist.";
        }

        return incorrectClues;
    }
}