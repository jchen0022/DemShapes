using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // Update is before rendering
    // FixedUpdate is right before any physics calculations
    
    public float speed;
    private Rigidbody2D rigidBody;

    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate() {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVeritcal = Input.GetAxisRaw("Vertical");
        
        Vector2 movement = new Vector2(moveHorizontal, moveVeritcal);

        rigidBody.AddForce(movement * speed);
    }

}
