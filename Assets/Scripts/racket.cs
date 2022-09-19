using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket : MonoBehaviour {
    //movement speed
    public float speed = 150;

    void FixedUpdate () {
        //get horizontal input
        float h = Input.GetAxisRaw("Horizontal");

        //set velocity (movement direction x speed)
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}