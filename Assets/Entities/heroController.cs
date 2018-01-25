using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroController : MonoBehaviour {

	float speed = 4f;
	public float jumpHeight = 7.2f;

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
			heroBody.velocity = new Vector2 (0, jumpHeight);
			Debug.Log ("Jumping");
		}
	}

}
