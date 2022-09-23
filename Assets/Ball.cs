using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    //movement speed 
    public float speed = 100.0f;

    //use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    void OnCollisionEnter2D(Collision2D col) {
        //this is called when ball collides
        if (col.gameObject.name == "racket") {
            //calculate hit factor
            float x=hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

            //calculate direction length to 1
            Vector2 dir = new Vector2(x,1).normalized;

            //set velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
    
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth) 
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }
}