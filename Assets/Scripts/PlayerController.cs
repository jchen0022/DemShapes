using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // Update is before rendering
    // FixedUpdate is right before any physics calculations
    
    public float speed;
    private Rigidbody2D rigidBody;
    private bool isSpedUp;

    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
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

}
