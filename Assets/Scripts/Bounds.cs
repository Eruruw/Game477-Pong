using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    private AudioSource myAudio;
    void Start(){
        myAudio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D colide = collision.GetComponent<Rigidbody2D>();
        if (colide.CompareTag("Ball"))
        {
            Debug.Log("This");
            myAudio.Play();
            colide.velocity = new Vector2(colide.velocity.x, colide.velocity.y * -1);
        }
    }
}
