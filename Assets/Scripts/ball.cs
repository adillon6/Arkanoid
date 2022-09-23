using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour 
{
    // Movement Speed
    public float speed = 100.0f;

    // Use this for initialization
    void Start () 
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
 //make sure brackets lined up
    void OnCollisionEnter2D(Collision2D col) 
    {float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketWidth) {
    // ascii art:
    //
    // 1  -0.5  0  0.5   1  <- x value
    // ===================  <- racket
    //
    return (ballPos.x - racketPos.x) / racketWidth;
}
        if (col.gameObject.name == "racket") 
        { 
            float x=hitFactor(transform.position,
                          col.transform.position,
                          col.collider.bounds.size.x);
            //calculate direction 
            Vector2 dir = new Vector2(x, 1).normalized;

            //set velocity using dir * speed;
        }
    }
}
