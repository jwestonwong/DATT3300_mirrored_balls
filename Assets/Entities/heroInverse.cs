using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroInverse : MonoBehaviour {

	float speed = 4f;
	public float jumpHeight = 7.2f;
	public bool canJump = true;

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
		//as with the other code, this may switch
		if (Input.GetKey (KeyCode.D)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
	}

	void Jump(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (canJump) {
				heroBody.velocity = new Vector2 (0, jumpHeight);
				Debug.Log ("Jumping");
				canJump = false;
			}
		}
	}

}
