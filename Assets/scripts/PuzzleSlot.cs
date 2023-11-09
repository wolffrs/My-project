using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzleSlot : MonoBehaviour, IDropHandler
{
        public int id; // Unique ID for the slots

    public void OnDrop(PointerEventData eventData) {
        if (transform.childCount == 0) {

            if (eventData.pointerDrag.GetComponent<DraggableItem>().id == id) {
                Debug.Log("correct");
                eventData.pointerDrag.GetComponent<DraggableItem>().correct = true;
            }

            else {
                Debug.Log("Incorrect");
                eventData.pointerDrag.GetComponent<DraggableItem>().correct = false;

            }

        GameObject dropped = eventData.pointerDrag;
        DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
        draggableItem.parentAfterDrag = transform;
        }
    }

}
