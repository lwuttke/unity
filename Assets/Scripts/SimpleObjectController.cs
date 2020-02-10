using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleObjectController : MonoBehaviour
{
    // Step 1: Define the speed of the player
    // Note: Private variables can only be accessed within the class they are declared in.
    // Public variables are also accessible from the Inspector.
    public float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        // Step 2: Retrieve axis horizontal and vertical information.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        // Note: Axis can be redefined in "Edit"->"Project Setting"->"Input"
        float moveY = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");

        // Step 3: Move object along the direction
        Vector2 direction = new Vector2(moveX, moveY);
        // Note: Make it move 5 units per second instead of 5 units per frame...
        transform.Translate(direction * speed * Time.deltaTime);

        // Alternatively, step 3: Change position 
        // Vector2 position = transform.position;
        // transform.position = position + (direction * speed * Time.deltaTime);

    }
}
