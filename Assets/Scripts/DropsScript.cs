using UnityEngine;
using System.Collections;

public class DropsScript : MonoBehaviour {

    private float time;

	// Use this for initialization
	void Start () {
        time = 3;
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if (time <= 0) {
            Destroy(gameObject);
        }
	}
}
