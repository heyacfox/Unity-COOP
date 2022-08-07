using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EightDirectionMovement : MonoBehaviour
{
    
    public KeyCode UpKey = KeyCode.UpArrow;
    public KeyCode DownKey = KeyCode.DownArrow;
    public KeyCode LeftKey = KeyCode.LeftArrow;
    public KeyCode RightKey = KeyCode.RightArrow;

    public float MoveSpeed = 1f;

    private Rigidbody2D myRigidbody;
    private float defaultMoveSpeedMultiplier = 5;
    private DirectionEight direction = DirectionEight.Down;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.gravityScale = 0;
    }

    void FixedUpdate()
    {
        float verticalMovement = 0;
        float horizontalMovement = 0;

        if (Input.GetKey(UpKey))
        {
            verticalMovement += 1f;
        }
        if (Input.GetKey(DownKey))
        {
            verticalMovement -= 1f;
        }
        if (Input.GetKey(LeftKey))
        {
            horizontalMovement -= 1f;
        }
        if (Input.GetKey(RightKey))
        {
            horizontalMovement += 1f;
        }

        Vector3 movementVector = new Vector3(horizontalMovement, verticalMovement);

        movementVector.Normalize();
        setDirection(horizontalMovement, verticalMovement);

        myRigidbody.MovePosition(transform.position + (movementVector * MoveSpeed * defaultMoveSpeedMultiplier * Time.deltaTime));
    }

    public void setDirection(float horizontal, float vertical)
    {
        if (horizontal == 0)
        {
            if (vertical > 0)
            {
                direction = DirectionEight.Up;
            } else if (vertical < 0)
            {
                direction = DirectionEight.Down;
            }
        }

        if (vertical == 0)
        {
            if (horizontal > 0)
            {
                direction = DirectionEight.Right;
            } else if (horizontal > 0)
            {
                direction = DirectionEight.Left;
            }
        }

        if (horizontal < 0)
        {
            if (vertical > 0)
            {
                direction = DirectionEight.UpLeft;
            } else if (vertical < 0)
            {
                direction = DirectionEight.DownLeft;
            }
        }

        if (horizontal > 0)
        {
            if (vertical > 0)
            {
                direction = DirectionEight.UpRight;
            } else if (vertical < 0)
            {
                direction = DirectionEight.DownRight;
            }
        }

    }
}
