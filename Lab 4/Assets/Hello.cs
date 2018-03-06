//Matthew Gelowitz
//200378966

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//print ("Yo, Earth!");  

		print (myPos ());
	}

	// Update is called once per frame
	void Update () {

		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		move ();
	}

	Vector3 myPos(){
		return this.transform.position;
		//print (this.transform.position);
	}

	void move(){
		if (Input.GetKey (KeyCode.W)) {                //movement in the positive z direction (away)
			transform.Translate (0f, 0f, 0.1f);
		}

		if (Input.GetKey (KeyCode.S)) {                //movement in the negative z direction (inwards)
			transform.Translate (0f, 0f, -0.1f);
		}

		if (Input.GetKey (KeyCode.A)) {                //movement in the negative x direction (left)
			transform.Translate (-0.1f, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (0.1f, 0f, 0f);        //movement in the positive x direction (right)
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {        //rotates counterclockwise horizontally
			transform.Rotate (0f, -1f, 0f);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {    //rotates clockwise horizontally
			transform.Rotate (0f, 1f, 0f);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {        //rotates upwards
			transform.Rotate (-1f, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {        //rotates downwards
			transform.Rotate (1f, 0f, 0f);
		}

		float h = Input.GetAxis ("Mouse X")*3.0f;
		float i = Input.GetAxis ("Mouse Y")*3.0f;
		transform.Rotate (0, h, 0);
		transform.Rotate (-i, 0, 0);    //negative prevents it from being inverted
	}
}
