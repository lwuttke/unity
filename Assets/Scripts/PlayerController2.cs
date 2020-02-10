using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rig;
    private Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        //Time.timeScale = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        float moveY = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");

        dir = new Vector3(moveX, moveY,0);
    }

    private void FixedUpdate()
    {
        rig.MovePosition(transform.position + speed * dir * Time.fixedDeltaTime);
    }
}
