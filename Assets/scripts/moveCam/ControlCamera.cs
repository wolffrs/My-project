using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public Camera mainCamera;
    public float panSpeed = 5f;

    public List<Transform> levels; // List of levels
    private int currentLevelIndex = 0; // Index of the current level

    void Start()
    {
        // Initialize camera position as needed
    }

    public void PanToNextLevel()
    {
        if (currentLevelIndex < levels.Count - 1)
        {
            currentLevelIndex++;
            Vector3 targetPosition = levels[currentLevelIndex].position;
            StartCoroutine(MoveCamera(targetPosition));
          //  Debug.Log("Next room");
        }
    }

    public void PanToPreviousLevel()
    {
        if (currentLevelIndex > 0)
        {
            currentLevelIndex--;
            Vector3 targetPosition = levels[currentLevelIndex].position;
            StartCoroutine(MoveCamera(targetPosition));
           // Debug.Log("Previous room");

        }
    }

    IEnumerator MoveCamera(Vector3 targetPosition)
    {
    
    targetPosition.z = mainCamera.transform.position.z; // Set the target z to be the same as the camera's z

    while (Vector3.Distance(mainCamera.transform.position, targetPosition) > 0.1f)
    {
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, targetPosition, Time.deltaTime * panSpeed);
        yield return null;
    }

    mainCamera.transform.position = targetPosition;
    }

}
