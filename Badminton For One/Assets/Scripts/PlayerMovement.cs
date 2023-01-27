using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    Rigidbody2D RB;
    public float moveSpeed = 0.05f;
    public bool paddleReady = true;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
        RB.position += new Vector2(moveSpeed*Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.A))
        {
        RB.position += new Vector2(-moveSpeed*Time.deltaTime,0);
        }
    }
}
