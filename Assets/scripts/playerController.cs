using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float moveSpeed = 1000f;

	Rigidbody rb;
	canvasController cc;
	Vector3 offset;
	// Use this for initialization

	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		cc = GameObject.Find("Canvas").GetComponent<canvasController>();
		// Variable scope!
		offset = (Camera.main.transform.position - this.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		float hdir = Input.GetAxisRaw("Horizontal");
		float vdir = Input.GetAxisRaw("Vertical");

		Vector3 directionVector = new Vector3 (hdir, 0, vdir);
		Vector3 unitVector = directionVector.normalized;
		Vector3 forceVector = unitVector * moveSpeed * Time.deltaTime;

		Camera.main.transform.position = this.transform.position + offset;

		rb.AddForce (forceVector);



	}
	
	void OnTriggerEnter(Collider other) 
	{

		if (other.gameObject.tag == "Collectible")
		{
			cc.IncreaseScore(10);
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "Banana")
		{
			cc.IncreaseScore(50);
			Destroy(other.gameObject);
		}

		//Debug.Log("colliding");
		//if (other.gameObject.tag == "Banana")
		//{
		//	Debug.Log("inside if");
		//	cc.IncreaseScore(50);
		//	Destroy(other.gameObject);
		//}
	}



}
/*
	void OnTriggerEnter(Collider other) 
		{
			if (other.gameObject.tag == "SuperCollectible")
			{
				Destroy(other.gameObject);
			}
			
		}
}

*/