using UnityEngine;
using System.Collections;

public class DropsScript : MonoBehaviour {

    public float time;

	// Use this for initialization
	void Start () {
        time = 8;
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if (time <= 0) {
            Destroy(gameObject);
        }
	}
}
