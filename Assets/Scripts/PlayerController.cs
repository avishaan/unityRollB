using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public float speed; // public var shows up in editor as a property
  public Text countText;
  public Text winText;

  private int count;
	private Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody> ();
    count = 0;
    SetCountText ();
    winText.text = "";
	}
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVerticle = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVerticle);

		rb.AddForce (movement * speed);
	}

  void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("Pick Up")){
      other.gameObject.SetActive (false);
      count = count + 1;
      SetCountText();
    }
  }

  void SetCountText() {
    countText.text = "Count: " + count.ToString();
    if (count >= 13) {
      winText.text = "You Win !!!";
    }
  }

}
