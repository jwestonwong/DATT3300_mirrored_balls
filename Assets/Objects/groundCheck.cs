using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour {

	private heroController hC;
	private heroInverse hI;
	private GreenPlatform GP;
	private ReversePlatform RP;

	// Use this for initialization
	void Start () {
		hC = GameObject.FindObjectOfType<heroController>();
		hI = GameObject.FindObjectOfType<heroInverse>();
		GP = GetComponent<GreenPlatform> ();
		RP = GetComponent<ReversePlatform> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (GP != null) {
			if (GP.isSolid == true) {
				if (other.tag == "Player") {
					Debug.Log ("On Ground");
					hC.canJump = true;
				}
				if (other.tag == "Inverse") {
					hI.canJump = true;
				}
			}
		}
		if (RP != null) {
			if (RP.isSolid == true) {
				if (other.tag == "Player") {
					Debug.Log ("On Ground");
					hC.canJump = true;
				}
				if (other.tag == "Inverse") {
					hI.canJump = true;
				}
			}
		}
		if (tag == "Sand") {
			if (other.tag == "Player") {
				Debug.Log ("On Ground");
				hC.canJump = true;
			}
			if (other.tag == "Inverse") {
				hI.canJump = true;
			}
		}
	}
}
