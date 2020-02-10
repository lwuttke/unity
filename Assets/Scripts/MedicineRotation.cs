using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineRotation : MonoBehaviour
{
    private GameObject medicine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        medicine.transform.Rotate(2,2,2);
    }
}
