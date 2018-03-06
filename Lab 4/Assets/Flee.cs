/* program: flee.cs
 * author: Matthew Gelowitz
 * Student number: 200378966
 * make object follow your character
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : MonoBehaviour {

	public float speed;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Get the distance between two objects
		float dist = Vector3.Distance(player.transform.position, transform.position);

		Vector3 localPosition = player.transform.position - transform.position;
		localPosition = localPosition.normalized;

		if (dist < 5) {
			transform.Translate (localPosition.x * Time.deltaTime * speed * -1,
				0.0f,
				localPosition.z * Time.deltaTime * speed * -1);	//multiply by a negative value to make it run away instead of chase
		}
	}
}
