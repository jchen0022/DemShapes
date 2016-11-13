using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
		
	// Update is called once per frame
	// Guarantees that it is called after all items have been called in Update
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
