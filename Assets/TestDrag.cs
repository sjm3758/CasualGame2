using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrag : MonoBehaviour {

    bool isPicked;
	
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            isPicked = false;
        }
        if (isPicked == true)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos;
        }
	}

    void OnMouseDown()
    {
        isPicked = true;
    }
}
