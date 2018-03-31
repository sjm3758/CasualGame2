using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayScript : MonoBehaviour {

    private Button btn;

	// Use this for initialization
	void Start () {
        btn = this.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(LoadLevel);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LoadLevel()
    {
        SceneManager.LoadScene("Level1test");
    }
}
