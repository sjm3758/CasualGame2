using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrag : MonoBehaviour {

    bool isPicked;
    Vector3 pos;
	
    // Use this for initialization
	void Start () {

        pos = transform.position;
       

    }
	
	// Update is called once per frame
	void Update () {
        pos.x = Mathf.RoundToInt(gameObject.transform.position.x);
        pos.y = Mathf.RoundToInt(gameObject.transform.position.y);

        if (Input.GetMouseButtonUp(0))
        {
            isPicked = false;
            Debug.Log(pos.x);
            Debug.Log(pos.y);
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
