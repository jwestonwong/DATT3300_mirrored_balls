using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlatform : MonoBehaviour {

	private SpriteRenderer sprite;
	private Collider2D coll;

	public Sprite[] sprites;
	public buttonPress button;

	private heroController hC;
	private heroInverse hI;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		coll = GetComponent<Collider2D> ();
		sprite.sprite = (sprites [0]);
		coll.isTrigger = false;
		hC = GameObject.FindObjectOfType<heroController>();
		hI = GameObject.FindObjectOfType<heroInverse>();
	}
	
	// Update is called once per frame
	void Update () {
		//Switches between being visible and touchable and invisible and intangiable
		if (button != null) {
			if (button.Pressed == false) {
				sprite.sprite = (sprites [0]);
				coll.isTrigger = false;
			} else {
				sprite.sprite = (sprites [1]);
				coll.isTrigger = true;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			Debug.Log ("On Ground");
			hC.canJump = true;
			hI.canJump = true;
		}
	}

}
