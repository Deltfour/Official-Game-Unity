using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 

    //Private Variables
    private float speed = 6f;
    private float turnSpeed = 25f;
    private float HorizontalInput;
    private float forwardInput;
   
    void Start()
    {
        
    }


    void Update()
    {
        //This is where we get player input
        HorizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //We turn the vehicle
        transform.Translate(Vector3.forward  * Time.deltaTime * speed * forwardInput); 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * HorizontalInput);
    }
}
