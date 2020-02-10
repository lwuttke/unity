using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedicineWeapon : MonoBehaviour
{
    // Step 1: Define member variables
    // Medicine prefab for shooting, needed to set the shot that will be used with this weapon
    public Transform shotPrefab;
    public float cooldownTime = 0.5f;
    public float nextFireTime = 0;
    public Text text;

    // Update is called once per frame
    void Update()
    {
        // Step 2: Read the input from a fire button
        // Note: You can notice that we use the GetButtonDown() method to get an input.
        // The “Down” at the end allows us to get the input when the button has been pressed once and only once.
        // GetButton() returns true at each frame until the button is released. In our case, we clearly want the behavior of the GetButtonDown() method.
        // Try to use GetButton() instead, and observe the difference.
        bool shoot = Input.GetButtonDown("Jump"); // You can also use "Fire1, ..", but be careful: For Mac users, ctrl + arrow is a bad idea

        if(Time.time > nextFireTime)
        if (shoot)
        {
            // Step 3: Create a new shot
            // Instantiate a clone of the prefab. Note: Instantiate can be used to create new objects at runtime.
            // Examples include objects used for projectiles, or particle systems for explosion effects.
            Transform shotTransform = Instantiate(shotPrefab);
            // Step 4: Assign start position
            shotTransform.position = transform.position;

                nextFireTime = Time.time + 1;

        }

    }

}

