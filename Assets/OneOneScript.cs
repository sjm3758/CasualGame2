using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneOneScript : MonoBehaviour {

    Vector3 pos;

	// Use this for initialization
	void Start ()
    {
        pos = this.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        pos.x = Mathf.RoundToInt(gameObject.transform.position.x);
        pos.y = Mathf.RoundToInt(gameObject.transform.position.y);

        if (!gameObject.GetComponent<TestDrag>().isPicked)
        {
            if (pos.x <= 1.3f && pos.x >= 0.0f)
            {

                if (pos.y >= -1.3f && pos.y <= 0.0f)
                {
                    transform.position = new Vector2(0.7f, -0.7f);

                }
                if (pos.y >= -2.5f && pos.y <= -1.3f)
                {
                    transform.position = new Vector2(0.7f, -2.0f);

                }
                if (pos.y >= -3.8f && pos.y <= -2.5f)
                {
                    transform.position = new Vector2(0.7f, -3.2f);

                }
                if (pos.y >= -5.2f && pos.y <= -3.8f)
                {
                    transform.position = new Vector2(0.7f, -4.5f);

                }
                if (pos.y >= -6.5f && pos.y <= -5.2f)
                {
                    transform.position = new Vector2(0.7f, -5.8f);

                }
                if (pos.y >= -7.7f && pos.y <= -6.5f)
                {
                    transform.position = new Vector2(0.7f, -7.1f);

                }
                if (pos.y >= -8.9f && pos.y <= -7.7f)
                {
                    transform.position = new Vector2(0.7f, -8.4f);

                }

            }
            if (pos.x <= 2.7f && pos.x >= 1.3f)
            {

                if (pos.y >= -1.3f && pos.y <= 0.0f)
                {
                    transform.position = new Vector2(2.0f, -0.7f);

                }
                if (pos.y >= -2.5f && pos.y <= -1.3f)
                {
                    transform.position = new Vector2(2.0f, -2.0f);

                }
                if (pos.y >= -3.8f && pos.y <= -2.5f)
                {
                    transform.position = new Vector2(2.0f, -3.2f);

                }
                if (pos.y >= -5.2f && pos.y <= -3.8f)
                {
                    transform.position = new Vector2(2.0f, -4.5f);

                }
                if (pos.y >= -6.5f && pos.y <= -5.2f)
                {
                    transform.position = new Vector2(2.0f, -5.8f);

                }
                if (pos.y >= -7.7f && pos.y <= -6.5f)
                {
                    transform.position = new Vector2(2.0f, -7.1f);

                }
                if (pos.y >= -8.9f && pos.y <= -7.7f)
                {
                    transform.position = new Vector2(2.0f, -8.4f);

                }
            }
            if (pos.x < 3.9f && pos.x > 2.7f)
            {
                if (pos.y >= -1.3f && pos.y <= 0.0f)
                {
                    transform.position = new Vector2(3.3f, -0.7f);

                }
                if (pos.y >= -2.5f && pos.y <= -1.3f)
                {
                    transform.position = new Vector2(3.3f, -2.0f);

                }
                if (pos.y >= -3.8f && pos.y <= -2.5f)
                {
                    transform.position = new Vector2(3.3f, -3.2f);

                }
                if (pos.y >= -5.2f && pos.y <= -3.8f)
                {
                    transform.position = new Vector2(3.3f, -4.5f);

                }
                if (pos.y >= -6.5f && pos.y <= -5.2f)
                {
                    transform.position = new Vector2(3.3f, -5.8f);

                }
                if (pos.y >= -7.7f && pos.y <= -6.5f)
                {
                    transform.position = new Vector2(3.3f, -7.1f);

                }
                if (pos.y >= -8.9f && pos.y <= -7.7f)
                {
                    transform.position = new Vector2(3.3f, -8.4f);

                }
            }
            if (pos.x < 5.1f && pos.x > 3.9f)
            {
                if (pos.y >= -1.3f && pos.y <= 0.0f)
                {
                    transform.position = new Vector2(4.5f, -0.7f);

                }
                if (pos.y >= -2.5f && pos.y <= -1.3f)
                {
                    transform.position = new Vector2(4.5f, -2.0f);

                }
                if (pos.y >= -3.8f && pos.y <= -2.5f)
                {
                    transform.position = new Vector2(4.5f, -3.2f);

                }
                if (pos.y >= -5.2f && pos.y <= -3.8f)
                {
                    transform.position = new Vector2(4.5f, -4.5f);

                }
                if (pos.y >= -6.5f && pos.y <= -5.2f)
                {
                    transform.position = new Vector2(4.5f, -5.8f);

                }
                if (pos.y >= -7.7f && pos.y <= -6.5f)
                {
                    transform.position = new Vector2(4.5f, -7.1f);

                }
                if (pos.y >= -8.9f && pos.y <= -7.7f)
                {
                    transform.position = new Vector2(4.5f, -8.4f);

                }
            }
            if (pos.x < 6.5f && pos.x > 5.1f)
            {
                if (pos.y >= -1.3f && pos.y <= 0.0f)
                {
                    transform.position = new Vector2(5.8f, -0.7f);

                }
                if (pos.y >= -2.5f && pos.y <= -1.3f)
                {
                    transform.position = new Vector2(5.8f, -2.0f);

                }
                if (pos.y >= -3.8f && pos.y <= -2.5f)
                {
                    transform.position = new Vector2(5.8f, -3.2f);

                }
                if (pos.y >= -5.2f && pos.y <= -3.8f)
                {
                    transform.position = new Vector2(5.8f, -4.5f);

                }
                if (pos.y >= -6.5f && pos.y <= -5.2f)
                {
                    transform.position = new Vector2(5.8f, -5.8f);

                }
                if (pos.y >= -7.7f && pos.y <= -6.5f)
                {
                    transform.position = new Vector2(5.8f, -7.1f);

                }
                if (pos.y >= -8.9f && pos.y <= -7.7f)
                {
                    transform.position = new Vector2(5.8f, -8.4f);

                }
            }
            if (pos.x < 7.7f && pos.x > 6.5f)
            {
                if (pos.y >= -1.3f && pos.y <= 0.0f)
                {
                    transform.position = new Vector2(7.1f, -0.7f);

                }
                if (pos.y >= -2.5f && pos.y <= -1.3f)
                {
                    transform.position = new Vector2(7.1f, -2.0f);

                }
                if (pos.y >= -3.8f && pos.y <= -2.5f)
                {
                    transform.position = new Vector2(7.1f, -3.2f);

                }
                if (pos.y >= -5.2f && pos.y <= -3.8f)
                {
                    transform.position = new Vector2(7.1f, -4.5f);

                }
                if (pos.y >= -6.5f && pos.y <= -5.2f)
                {
                    transform.position = new Vector2(7.1f, -5.8f);

                }
                if (pos.y >= -7.7f && pos.y <= -6.5f)
                {
                    transform.position = new Vector2(7.1f, -7.1f);

                }
                if (pos.y >= -8.9f && pos.y <= -7.7f)
                {
                    transform.position = new Vector2(7.1f, -8.4f);

                }
            }
            if (pos.x < 8.9f && pos.x > 7.7f)
            {
                if (pos.y >= -1.3f && pos.y <= 0.0f)
                {
                    transform.position = new Vector2(8.4f, -0.7f);

                }
                if (pos.y >= -2.5f && pos.y <= -1.3f)
                {
                    transform.position = new Vector2(8.4f, -2.0f);

                }
                if (pos.y >= -3.8f && pos.y <= -2.5f)
                {
                    transform.position = new Vector2(8.4f, -3.2f);

                }
                if (pos.y >= -5.2f && pos.y <= -3.8f)
                {
                    transform.position = new Vector2(8.4f, -4.5f);

                }
                if (pos.y >= -6.5f && pos.y <= -5.2f)
                {
                    transform.position = new Vector2(8.4f, -5.8f);

                }
                if (pos.y >= -7.7f && pos.y <= -6.5f)
                {
                    transform.position = new Vector2(8.4f, -7.1f);

                }
                if (pos.y >= -8.9f && pos.y <= -7.7f)
                {
                    transform.position = new Vector2(8.4f, -8.4f);

                }
            }
        }
        
    }
}
