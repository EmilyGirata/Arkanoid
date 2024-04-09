using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{

    public float speed = 150;

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");

        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }

    //void OnTriggerEnter2D(Collider2D hit)
    //{
    //    if (hit.gameObject.name == "border_bottom")
    //    {

    //        Health.health--;

    //        rb.isKinematic = true;
    //        rb.velocity = new Vector2(0f, 0f);
    //        transform.localPosition = new Vector3 (0f, 0.65f, 0f);
    //    }
    //}
}
