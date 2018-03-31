using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour {

    GameObject[] pieces;
    public bool winTheGame;
    TestDrag[] drags;
    

	// Use this for initialization
	void Start () {
        pieces = GameObject.FindGameObjectsWithTag("Player");
        drags = TestDrag.FindObjectsOfType(typeof(TestDrag)) as TestDrag[];
        foreach (GameObject piece in pieces)
        {
            Debug.Log("A Piece");
           
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
       /* foreach (TestDrag drag in drags)
        {
            if (!drag.inPosition)
            {
                winTheGame = false;
            }
            else
            {
                winTheGame = true;
            }
        }
        */
        for (int i = 0; i < pieces.Length; i++)
        {
            if (!pieces[i].GetComponent<TestDrag>().inPosition)
            {
                winTheGame = false;
               // Debug.Log("Piece" + i + "not in position");
            }
            else
            {
                winTheGame = true;
            }

            
        }

        
    }
}
