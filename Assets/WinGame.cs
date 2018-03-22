using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("Colission").GetComponent<TestCollision>().inTile)
        {
            Debug.Log("Win");
        }
    }

    void winGame()
    {
      
    }
}
