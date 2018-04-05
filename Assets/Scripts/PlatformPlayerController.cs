using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlayerController : MonoBehaviour {
    private Rigidbody2D rb;

    public float speed = 1;
    public float jumpSpeed = 3;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalInput = Input.GetAxis("Horizontal");
        bool jump = Input.GetKey("space");
        Vector2 movementVector = new Vector2(horizontalInput, jump ? transform.up.y * jumpSpeed : rb.velocity.y);
        Move(movementVector);
	}

    private void Move(Vector2 movementVector)
    {
        rb.velocity = movementVector * speed;
    }
}
