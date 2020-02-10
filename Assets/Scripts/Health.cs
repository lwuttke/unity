using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hits = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Shot shot = collision.gameObject.GetComponent<Shot>();
        if(shot != null)
        {
            hits--;
            if(hits <= 0)
            {
                SpriteRenderer r = GetComponent<SpriteRenderer>();
                r.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
