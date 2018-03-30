using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrag : MonoBehaviour {

    bool isPicked;
    public static int Row = 7;
    public static int Col = 7;

    public int[,] coord = new int[Row, Col];

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
            if (pos.x < 1f && pos.x > 0.1f)
            {
                if (pos.y > -1f && pos.y < -0.1f)
                {
                    transform.position = new Vector2(0.5f, -0.5f);
                    Debug.Log("Activated");
                }
                if (pos.y > -2f && pos.y < -0.6f)
                {
                    transform.position = new Vector2(1.5f, -1.5f);
                    Debug.Log("Activated");
                }
                if (pos.y > -3f && pos.y < -1.6f)
                {
                    transform.position = new Vector2(1.5f, -2.5f);
                    Debug.Log("Activated");
                }

            }
            if (pos.x < 2f && pos.x > 0.6f)
            {
                if (pos.y > -2f && pos.y < -0.6f)
                {
                    transform.position = new Vector2(1.5f, -1.5f);
                    Debug.Log("Activated");
                }
                if (pos.y > -1f && pos.y < -0.1f)
                {
                    transform.position = new Vector2(1.5f, -0.5f);
                    Debug.Log("Activated");
                }
                if (pos.y > -3f && pos.y < -1.6f)
                {
                    transform.position = new Vector2(1.5f, -2.5f);
                    Debug.Log("Activated");
                }

            }
            if (pos.x < 3f && pos.x > 1.6f)
            {
                if (pos.y > -2f && pos.y < -0.6f)
                {
                    transform.position = new Vector2(1.5f, -1.5f);
                    Debug.Log("Activated");
                }
                if (pos.y > -1f && pos.y < -0.1f)
                {
                    transform.position = new Vector2(1.5f, -0.5f);
                    Debug.Log("Activated");
                }
                if (pos.y > -3f && pos.y < -1.6f)
                {
                    transform.position = new Vector2(1.5f, -2.5f);
                    Debug.Log("Activated");
                }
            }
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
