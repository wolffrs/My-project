using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
    }

        void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        //Destroy(gameObject);
        Debug.Log("Goed zo");
    }
}
