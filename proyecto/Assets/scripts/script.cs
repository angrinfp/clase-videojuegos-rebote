using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
	public Rigidbody2D bird;

	private float forceX = 10.0f;
	private float forceY = 12.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector2 forceLeft = new Vector2 (-forceX, 0);
			bird.AddForce (forceLeft);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector2 forceRight = new Vector2 (forceX, 0);
			bird.AddForce (forceRight);
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			Vector2 forceUp = new Vector2 (0, forceY);
			bird.AddForce (forceUp);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			Vector2 forceDown = new Vector2 (0, -forceY);
			bird.AddForce (forceDown);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		string name = collision.gameObject.name;
		if (name == "detector") {
			gameObject.SetActive (false);
		}
	}
}
