using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TestDrag : MonoBehaviour {

    bool isPicked;
    //give the script access to the grid
    public Tilemap grid;
	
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            isPicked = false;
            //snap piece to grid
            Vector2 mousePos = Input.mousePosition;
            Vector3 cellPos = grid.LocalToCell(mousePos);
            transform.position = cellPos;
            //UnityEngine.Debug.Log("Snapping to " + cellPos);
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
