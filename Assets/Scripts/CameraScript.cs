using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

  public GameObject player;

  private Vector3 offset;

	// Use this for initialization
	void Start () {
    offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame after everything else has processed and run
	void LateUpdate () {
    transform.position = player.transform.position + offset;
	}
}
