using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {

	private float tChange = 0;
	private float randomX;
	private float randomY;
	private float moveSpeed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float leftx = (float) -7.79;
		float rightx = (float) 7.79;
		float bottomy = (float) -5.0;
		float topy = (float) 5.0;
		if (Time.time >= tChange) {
			randomX = Random.Range((float) -2.0, (float) 2.0);
			randomY = Random.Range((float) -2.0, (float) 2.0);
			tChange = Time.time + Random.Range((float) 0.5, (float) 1.5);
		}

		transform.Translate(new Vector3(randomX, randomY, 0) * moveSpeed * Time.deltaTime);

		if (transform.position.x < leftx || transform.position.x > rightx ||
			transform.position.y < bottomy || transform.position.y > topy) {
			Destroy(this);
		}
	}

}
