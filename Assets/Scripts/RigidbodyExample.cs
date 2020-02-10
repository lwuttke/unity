using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyExample : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rig;
    private bool keyPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = new Vector2(-speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            keyPressed = true;
            
    }
    private void FixedUpdate()
    {
        if(keyPressed)
        {
            rig.AddForce(transform.up * 10.0f, ForceMode2D.Impulse);
            keyPressed = false;
        }
            
    }
}
