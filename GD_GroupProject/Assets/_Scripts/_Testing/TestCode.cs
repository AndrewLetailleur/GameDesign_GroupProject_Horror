using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestCode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			SceneManager.LoadScene("GameOver");
		}/* else if (Input.GetKeyDown (KeyCode.Mouse1)) {
			SceneManager.LoadScene("TimeOut");
		}*/
	}
}
