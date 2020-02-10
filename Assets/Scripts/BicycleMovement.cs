using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleMovement : MonoBehaviour
{
    public float speed = 25.0f;
    private Rigidbody2D rig;
    private Vector3 dir;
    private Vector2 up;
    Transform jumper;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        //Time.timeScale = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
       // float moveY = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");
       // float jump = Input.GetAxis("Vertical");
        bool jump = Input.GetButtonDown("Jump");


        dir = new Vector3(moveX, 0, 0);
        up = new Vector2(0, 5);

        if (jump)
        {
            // Step 3: Create a new shot
            // Instantiate a clone of the prefab. Note: Instantiate can be used to create new objects at runtime.
            // Examples include objects used for projectiles, or particle systems for explosion effects.
            //Transform shotTransform = Instantiate(shotPrefab);
            // Step 4: Assign start position
            transform.Translate(up, Space.World);

           

        }

    }

    private void FixedUpdate()
    {
        rig.MovePosition(transform.position + speed * dir * Time.fixedDeltaTime);
    }
}