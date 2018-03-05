using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzlePiece : MonoBehaviour
{

    [SerializeField]
    RectTransform rectTransform;
    [SerializeField]
    Vector2 boardSize;
    bool drag = false;


    // Use this for initialization
    void Start()
    {
        //generate piece from color map?
        //store every segment of the piece in an array
        //each segment has a fill property indicating if it's inside the outline

        //get board size for drag and drop behavior
        //boardSize = transform.parent.GetComponentInParent<RectTransform>().rect.size / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //click and drag
        //when held, change color slightly and make a sound
        //when released, make another sound and snap to nearest grid point
        //
    }

    public void OnHold(BaseEventData eventData)
    {

    }

    public void OnDrag(BaseEventData eventData)
    {
        rectTransform.anchoredPosition = ((PointerEventData)eventData).position - boardSize;
    }

    void OnMouseDown()
    {
        drag = true;
    }

    void OnMouseUp()
    {
        drag = false;
    }

    void OnMouseDrag()
    {
        if (drag)
        {
            //get mouse position
            Vector2 cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //set position to mouse position
            rectTransform.anchoredPosition = cursor;
        }
    }
}
