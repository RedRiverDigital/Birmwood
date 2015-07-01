using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public bool isPaused = false;
	public GameObject pauseMenu;

	void Start () {
		if(pauseMenu) pauseMenu.SetActive (false);
		Time.timeScale = 1.0f;
		isPaused = false;
	}
	
	void Update () {
		if(Input.GetKeyUp(KeyCode.Escape)) {
			TriggerPause();
		}
	}

	public void TriggerPause() {
		if(isPaused) {
			Time.timeScale = 1.0f;
			isPaused = false;
			if(pauseMenu) pauseMenu.SetActive(false);
		}
		else {
			Time.timeScale = 0.0f;
			isPaused = true;
			if(pauseMenu) pauseMenu.SetActive(true);
		}
	}
}
