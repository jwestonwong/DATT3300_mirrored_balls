using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroController : MonoBehaviour {

	float speed = 4f;
	public float jumpHeight = 8f;
	public bool canJump = true;
	//This should be 8, but you should also double check in the editor to make sure it works

	private Rigidbody2D heroBody;

	// Use this for initialization
	void Start () {
		heroBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
		Jump ();
	}

	void Movement(){
		//The movement is pretty basic and then the movement is inverted for the inverse Hero
		//In the future I'll be working on tying the two of them directly together instead of
		//each doing the math independently
		if (Input.GetKey (KeyCode.D)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
	}

	void Jump(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (canJump) {
				canJump = false;
				heroBody.velocity = new Vector2 (0, jumpHeight);
				Debug.Log ("Jumping");
			}
		}
	}

}
