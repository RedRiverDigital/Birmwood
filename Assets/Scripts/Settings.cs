using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

	public Text scrollSpeedText;
	public Text rotateSpeedText;
	public CameraControl cam;

	void Update () {
		scrollSpeedText.text = ((int)cam.scrollSpeed).ToString();
		rotateSpeedText.text = ((int)cam.rotateSpeed).ToString();
		Debug.Log("Rotate: "+cam.rotateSpeed);
		Debug.Log("Scroll: "+cam.scrollSpeed);
	}
}
