using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed; // public var shows up in editor as a property
	private Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody> ();
	}
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVerticle = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVerticle);

		rb.AddForce (movement * speed);
	}

}
