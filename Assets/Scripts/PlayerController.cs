using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private variables 
    private float speed = 5.0f;
    private float turnSpeed = 30.0f;
    private float forwardInput; 
    private float horizontalInput; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // this is where we ge player input
        horizontalInput = Input.GetAxis("Horizontal"); 
        forwardInput = Input.GetAxis("Vertical");
        // moves the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // turns the vehicle 
        transform.Rotate(Vector3.up,  Time.deltaTime * turnSpeed * horizontalInput );
    }
}
