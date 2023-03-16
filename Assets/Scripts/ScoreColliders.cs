using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreColliders : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.attachedRigidbody.velocity.x > 0)
        {
            Debug.Log("Right score");
        }
        else
        {
            Debug.Log("Left Score");
        }
        collision.transform.position = new Vector2(0, 0);
    }
}
