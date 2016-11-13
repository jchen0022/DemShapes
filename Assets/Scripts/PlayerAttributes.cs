using UnityEngine;
using System.Collections;

public class PlayerAttributes : MonoBehaviour {

    private MaterialPropertyBlock propBlock;

	// Use this for initialization
	void Start () {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.color = new Color (0f, 0f, 0f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
