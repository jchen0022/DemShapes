using UnityEngine;
using System.Collections;

public class DropManager : MonoBehaviour {

	// Use this for initialization
    public GameObject player;

	void Start () {
        player = GameObject.Find("Player 1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Spawn() {
        Vector3 spawnPoint = player.transform.position;
    }
}
