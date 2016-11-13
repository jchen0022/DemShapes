using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour {

    // Update is before rendering
    // FixedUpdate is right before any physics calculations
    
    public float speed;
    private Rigidbody2D rigidBody;
    private bool isSpedUp;
    private int countFood;
    private float baseColliderRadius;
    private CircleCollider2D collider;
    private GameObject recentDrop;
    public GameObject pair;

    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
        collider = gameObject.GetComponent<CircleCollider2D>();
        baseColliderRadius = collider.radius;
        countFood = 0;
        recentDrop = null;
    }

    void Update() {
        isSpedUp = Input.GetKey("space");
    }
    
    void FixedUpdate() {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVeritcal = Input.GetAxisRaw("Vertical");
        
        Vector2 movement = new Vector2(moveHorizontal, moveVeritcal);
        
        if (isSpedUp) {
            rigidBody.AddForce(movement * ((float)(speed * 1.75)));
        } else {
            rigidBody.AddForce(movement * speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("New Food")) {
            Destroy(other.gameObject);
            countFood++;
            Debug.Log(countFood);
            float scale = (float) (1 + 0.1 * countFood); 
            transform.localScale = new Vector3(scale, scale, scale);
            collider.radius = (float) (baseColliderRadius * (1 + 0.001 * countFood)); 
        }
        if (other.gameObject.CompareTag("Circle Drop")) {
            Debug.Log("connect");
            if (other.gameObject.GetComponent<DropsScript>().time < 7.75) {
                if (recentDrop == null) {
                    recentDrop = other.gameObject; 
                } else {
                    connect(recentDrop, other.gameObject);
                    recentDrop = other.gameObject;
                }
            }
        }
    }

    void connect(GameObject drop1, GameObject drop2) {
        Vector3 spawnPoint = transform.position;
        GameObject p = Instantiate(pair, spawnPoint, Quaternion.identity) as GameObject;
        p.gameObject.GetComponent<PairsContoller>().drop1 = drop1;
        p.gameObject.GetComponent<PairsContoller>().drop2 = drop2;
    }

}
