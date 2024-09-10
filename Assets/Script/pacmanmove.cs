using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacmanmove : MonoBehaviour
{ 
    public float speed = 5f;
    private Vector3 moveDirection;

    void Update()
    {
        ProcessInputs();
        Move();
    }

    void ProcessInputs()
    {
        // Detect arrow key inputs and update movement direction
        if (Input.GetKey(KeyCode.UpArrow))
            moveDirection = Vector3.up;       // Upward movement along the Y axis
        else if (Input.GetKey(KeyCode.DownArrow))
            moveDirection = Vector3.down;     // Downward movement along the Y axis
        else if (Input.GetKey(KeyCode.LeftArrow))
            moveDirection = Vector3.left;     // Left movement along the X axis
        else if (Input.GetKey(KeyCode.RightArrow))
            moveDirection = Vector3.right;    // Right movement along the X axis
        else
            moveDirection = Vector3.zero;     // Stop moving if no key is pressed
    }

    void Move()
    {
        // Determine the new position
        Vector3 newPosition = transform.position + moveDirection * speed * Time.deltaTime;

        // Check for collisions with walls
        if (!IsCollidingWithWall(newPosition))
        {
            // Move Pac-Man if no collision detected
            transform.position = newPosition;
        }
    }

    bool IsCollidingWithWall(Vector3 newPosition)
    {
        // Cast a ray in the direction of movement to check for collisions
        RaycastHit hit;
        if (Physics.Raycast(transform.position, moveDirection, out hit, speed * Time.deltaTime))
        {
            // Check if the ray hit a wall (or any collider)
            if (hit.collider.CompareTag("Wall"))
            {
                return true; // Collision detected
            }
        }
        return false; // No collision
    }
}
