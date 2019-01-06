using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

	public float minimumX = -60f;
	public float maximumX = 60f;                                   
	public float minimumY = -360f;
	public float maximumY = 360;

	public float sensitivityX = 15f;
	public float sensitivityY = 15f;

	public Camera cam;

	float rotationY = 0f;
	float rotationX = 0f;

	Vector3 offset;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		offset = (Camera.main.transform.position - this.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
		rotationY += Input.GetAxis("Mouse X") * sensitivityY;
		rotationX += Input.GetAxis("Mouse Y") * sensitivityX;

		rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);

		transform.localEulerAngles = new Vector3(0, rotationY, 0);

		cam.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);

		Camera.main.transform.position = this.transform.position + offset;





	}
}







































//Cassidy




