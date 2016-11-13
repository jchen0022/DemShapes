using UnityEngine;
using System.Collections;

public class FoodSpawner : MonoBehaviour {

	public float spawnTime = 1f;
	public GameObject circleFood;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn() {
		float leftx = -7.79f;
		float rightx = 7.79f;
		float bottomy = -5.0f;
		float topy = 5.0f;
		float x = Random.Range(leftx, rightx);
		float y = Random.Range(bottomy, topy);
		Vector3 coord = new Vector3(x, y, 0);
		Instantiate(circleFood, coord, Quaternion.identity);
	}
}
