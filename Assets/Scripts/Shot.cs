using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Step 1: Limited time to live to avoid any leak
        // Kills the game object in 5 seconds 
        Destroy(gameObject, 5);
    }
}
