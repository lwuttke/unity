using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseScrolling : MonoBehaviour
{
    // Step 1: Define member variables
    // Moving speed of the scrolling element
    public float speed = 1f;
    // Direction of the scrolling element (from right to the left)
    public Vector2 direction = new Vector2(1.0f, 0.0f);

    // Update is called once per frame
    void Update()
    {
        // Step 2: Calculate movement of the scrolling element
        // Don't forget to multiply by the time between 2 frame to ensure our game is framerate independent
        Vector2 movement = direction * speed * Time.deltaTime;
        transform.Translate(movement);

    }
}