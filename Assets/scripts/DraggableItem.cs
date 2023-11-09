using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public int id; // Unique ID for item
    public bool correct = false;
    public bool finished = false;

    public TMPro.TextMeshProUGUI text;
    [HideInInspector] public Transform parentAfterDrag;


    public void OnBeginDrag(PointerEventData eventData) {
        if (finished == false) {
        //Debug.Log("begin drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        text.raycastTarget = false;
    }   }

    public void OnDrag(PointerEventData eventData) {
        //Debug.Log("dragging");
        transform.position = Input.mousePosition; 
    }

    public void OnEndDrag(PointerEventData eventData) {
        //Debug.Log("end drag");
        transform.SetParent(parentAfterDrag);
        text.raycastTarget = true;
    }

}
