using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour {

    private Button btn;

    // Use this for initialization
    void Start () {
        btn = this.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Restart);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
