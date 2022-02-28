using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float player1Speed;
    private Rigidbody2D rb;
    private Vector2 player1Direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        player1Direction = new Vector2(0, directionY).normalized;

    }

    void FixUpdate()
    {
        rb.velocity = new Vector2(0, player1Direction.y * player1Speed);
       
        //// timers or inputs
    }
}
