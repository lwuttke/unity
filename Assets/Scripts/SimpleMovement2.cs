using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Note: MonoBehaviour is the base class from which every Unity script derives.
//The class name must be the same as the filename!
public class SimpleMovement : MonoBehaviour
{
    float triggerTime = 2.0f;

    //Step 1: Define the speethe player
    // Note: Private variables can only be accessed within the class they are declared in.
    // Public variables are also accessible from the Inspector.
    public float speed = 0.5f;
    public Vector2 direction = Vector2.right;

    // Update is called once per frame
    void Update()
    {
        // Step 2: Get postion 2D position of the object and declare variable
        Vector2 position = transform.position;

        // Step 3: Change horizontal position
        // Multiplied by the time between 2 frame to ensure our game is framerate independent
        // For exmple, the object moves 0.5 unit/second along the negative x axis
        // position.x = position.x - speed * Time.deltaTime 
        
        position = position + (direction * speed * Time.deltaTime);
        transform.position = position;

        // Alternatively (Step 2 and 3), use the translate function
        // Note: If the last parameter is set to Space.Self (default value) the movement is applied relative to the transform's local axes.
        // (the x, y and z axes shown when selecting the object inside the Scene View.) If is set to Space.World the movement
        // is applied relative to the world coordinate system.
        // transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);

    }
}



