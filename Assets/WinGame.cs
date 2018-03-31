using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour {

    GameObject[] pieces;
    public bool winTheGame;

	// Use this for initialization
	void Start () {
        pieces = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject piece in pieces)
        {
            
        }
	}
	
	// Update is called once per frame
	void Update () {
        /* if (GameObject.FindGameObjectWithTag("Colission").GetComponent<TestCollision>().inTile)
         {
             Debug.Log("Win");
         }
         */
        Win();

        if (winTheGame)
        {
            Debug.Log("Win");
        }
    
        
    }

    public void Win()
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            if (!pieces[i].GetComponent<TestDrag>().inPosition)
            {
                winTheGame = false;
            }
            else
            {
                winTheGame = true;
            }
        }
    }
}
