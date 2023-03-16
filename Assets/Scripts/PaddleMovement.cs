using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public GameObject paddleL;
    public GameObject paddleR;
    private float moveSpeed = 0.05f;
    private bool bound;
    void Start()
    {
        bound = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            paddleL.transform.Translate(new Vector3(0, 1 * moveSpeed, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            paddleL.transform.Translate(new Vector3(0, -1 * moveSpeed, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            paddleR.transform.Translate(new Vector3(0, 1 * moveSpeed, 0));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            paddleR.transform.Translate(new Vector3(0, -1 * moveSpeed, 0));
        }
    }
}
