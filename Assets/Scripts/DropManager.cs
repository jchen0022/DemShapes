using UnityEngine;
using System.Collections;

public class DropManager : MonoBehaviour {

	// Use this for initialization
    public GameObject player;
    public GameObject drop;
    private bool isDropping;

    void Start () {
	}
	
    // Update is called once per frame
    void Update () {
        isDropping = Input.GetKey("space");
        if (isDropping) {
            Spawn();
        }
	}

    void Spawn() {
        Vector3 spawnPoint = player.transform.position;
        Instantiate(drop, spawnPoint, Quaternion.identity);
    }
}
