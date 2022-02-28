using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Vector3 playerDirection;
    private float screenWidth = Screen.width;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        TouchMove();
    }

    private void TouchMove()
    {
        if(Input.GetMouseButton(0))
        {
            playerDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(playerDirection.x > 1)
            {
                float directionX = 0.1f;
                transform.Translate(directionX * playerSpeed, 0, 0);
            }
            else if(playerDirection.x < -1)
            {
                float directionX = -0.1f;
                transform.Translate(directionX * playerSpeed, 0, 0);
            }
        }
    }
    void FixedUpdate()
    {
        
    }
}
