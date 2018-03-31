using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrag : MonoBehaviour {

    public bool isPicked;
    public bool inPosition;
    public bool inBounds;

	
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

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Colission")
        {
            if (!isPicked)
            {
                inPosition = true;
               // Debug.Log("In Position");
            }
            
        }
    }

   void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "NoCollide")
        {
            Debug.Log("false");
            inBounds = false;
        }
    }

   void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "NoCollide")
        {
            inBounds = true;
            Debug.Log("true");
        }

        if (coll.gameObject.tag == "Colission")
        {
              inPosition = false;
           // Debug.Log("Exited");
        }
    }
}
