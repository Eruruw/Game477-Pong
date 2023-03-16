using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D myBody = collision.GetComponent<Rigidbody2D>();
        myBody.velocity = new Vector2(myBody.velocity.x * -1, myBody.velocity.y);
    }
}