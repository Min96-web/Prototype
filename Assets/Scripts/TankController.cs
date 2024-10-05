using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    // Private Variables
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Move the Vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
