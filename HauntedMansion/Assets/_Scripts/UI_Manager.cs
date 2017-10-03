using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	  public void PlayHUD() {
		SceneManager.LoadScene("DEMO");
	} public void HelpHUD() {
		SceneManager.LoadScene("HelpMenu");
	} public void MainHUD() {
		SceneManager.LoadScene("MainMenu");
	}
}
