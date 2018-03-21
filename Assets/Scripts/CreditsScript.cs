using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour {

    private Button btn;

	// Use this for initialization
	void Start () {
        btn = this.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(SwitchToCredits);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SwitchToCredits()
    {
        SceneManager.LoadScene("CreditsScene");
    }
}
