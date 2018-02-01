using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour {

	private heroController hC;
	private heroInverse hI;

	// Use this for initialization
	void Start () {
		hC = GameObject.FindObjectOfType<heroController>();
		hI = GameObject.FindObjectOfType<heroInverse>();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			Debug.Log ("On Ground");
			hC.canJump = true;
			hI.canJump = true;
		}
	}
}
