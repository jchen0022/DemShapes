using UnityEngine;
using System.Collections;

public class DropManager : MonoBehaviour {

	// Use this for initialization
    public GameObject player;
    public GameObject drop;
    private bool isDropping;
    private float time;

    void Start () {
        time = 0;
	}
	
    // Update is called once per frame
    void Update () {
        isDropping = Input.GetKey("space");
        if (isDropping) {
            time -= Time.deltaTime;
            if (time <= 0) {
                Spawn();
                time = (float) 0.1;
            } 
        } else {
            time = 0;
        }
	}

    void Spawn() {
        Vector3 spawnPoint = player.transform.position;
        Instantiate(drop, spawnPoint, Quaternion.identity);
    }
}
