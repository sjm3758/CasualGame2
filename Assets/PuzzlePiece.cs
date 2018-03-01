using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzlePiece : MonoBehaviour {

    [SerializeField]
    RectTransform rectTransform;
    [SerializeField]
    Vector2 boardSize;
    [SerializeField]
    float speed;

    const string k_HORIZ = "Horizontal";
    const string k_VERT = "Vertical";


	// Use this for initialization
	void Start () {
        //generate piece from color map?
        //store every segment of the piece in an array
        //each segment has a fill property indicating if it's inside the outline

        //get board size for drag and drop behavior
        rectTransform = GetComponent<RectTransform>();
        boardSize = transform.parent.GetComponentInParent<RectTransform>().rect.size / 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
        //click and drag
#if UNITY_EDITOR
        Move(Input.GetAxis(k_HORIZ), Input.GetAxis(k_VERT));
#else
        Move(Input.acceleration.x, Input.acceleration.y);
#endif
        //when held, change color slightly and make a sound
        //when released, make another sound and snap to nearest grid point
        //
    }

    void Move(float x, float y)
    {
        //get new position
        Vector2 newPos = rectTransform.anchoredPosition;
        newPos.x += x * speed;
        newPos.y += y * speed;

        //limit new position to space of board dimension
        if (newPos.x < -boardSize.x) newPos.x = -boardSize.x;
        else if (newPos.x > boardSize.x) newPos.x = boardSize.x;
        if (newPos.y < -boardSize.y) newPos.y = -boardSize.y;
        else if (newPos.y > boardSize.y) newPos.y = boardSize.y;
        //apply modified new position to object
        rectTransform.anchoredPosition = newPos;
    }

    public void OnHold(BaseEventData eventData)
    {

    }

    public void OnTapDrag(BaseEventData eventData)
    {
        rectTransform.anchoredPosition = ((PointerEventData)eventData).position - boardSize;
    }
}
