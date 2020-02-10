using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRigidbodyMovement : MonoBehaviour
{
    // Step 1: Define member variables
    // Object speed
    public float speed = 8.0f;
    // Moving direction
    public Vector2 direction = new Vector2(1, 0);
    // Reference to the rigidbody component
    private Rigidbody2D rigidbodyComponent;


    // Start is called before the first frame update
    void Start()
    {
        // Step 2: Get the component and store the reference
        rigidbodyComponent = GetComponent<Rigidbody2D>();
        rigidbodyComponent.velocity = direction * speed;

    }

}
