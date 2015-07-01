using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public void Exit() {
		Application.Quit ();
	}
	public void Load(int index) {
		Application.LoadLevel (index);
	}
}
