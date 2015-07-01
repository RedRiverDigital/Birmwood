using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	Vector3 mousePosition;
	public Camera mainCamera;
	public PauseMenu pauseMenu;
	public GameObject player;

	public float rotateSpeed{get;set;}
	public float scrollSpeed{get;set;}

	void Start () {
		mousePosition = Input.mousePosition;
		if(!mainCamera) mainCamera = Camera.main;
		rotateSpeed = 10;
		scrollSpeed = 50;
	}
	
	void Update () {
		if(MouseInBounds () && !pauseMenu.isPaused) Cursor.visible = false;
		else Cursor.visible = true;
		if(!pauseMenu.isPaused) {
			RotateCamera();
			MoveCamera();
		}
	}

	bool MouseInBounds () {
		if(Input.mousePosition.x >= 0 && Input.mousePosition.x <= Screen.width && Input.mousePosition.y >= 0 && Input.mousePosition.y <= Screen.height) return true;
		return false;
	}

	void RotateCamera () {
		if(mousePosition.x != Input.mousePosition.x) {
			mainCamera.transform.RotateAround(player.transform.position,Vector3.up, (rotateSpeed/10)*(mousePosition.x - Input.mousePosition.x));
			mousePosition = Input.mousePosition;
		}
	}

	void MoveCamera() {
		Vector3 apparentPosition = new Vector3(player.transform.position.x,mainCamera.transform.position.y,player.transform.position.z);
		float scroll = Input.GetAxis("Mouse ScrollWheel");
		float distance = Vector3.Distance(apparentPosition,mainCamera.transform.position);
		if(scroll != 0 && distance >= 1 && distance <= 3) {
			Debug.Log("Moving");
			mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position,apparentPosition,scrollSpeed*scroll*Time.deltaTime);
		}
		else if(scroll > 0 && distance > 3) {
			Debug.Log("Moving");
			mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position,apparentPosition,scrollSpeed*scroll*Time.deltaTime);
		}
		else if(scroll < 0 && distance < 1) {
			Debug.Log("Moving");
			mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position,apparentPosition,scrollSpeed*scroll*Time.deltaTime);
		}
	}
}
